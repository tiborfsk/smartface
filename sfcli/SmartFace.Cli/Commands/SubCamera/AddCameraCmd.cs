using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Newtonsoft.Json;
using SmartFace.Cli.Common;
using SmartFace.Cli.Core.ApiAbstraction;
using SmartFace.Cli.Core.ApiAbstraction.Models;

namespace SmartFace.Cli.Commands.SubCamera
{
    [Command(Name = "add", Description = "Create new camera")]
    public class AddCameraCmd : BaseCameraModifyingCmd
    {
        [Required]
        [Option("-n|--name", "[Required] Name of the new camera.", CommandOptionType.SingleValue)]
        public override (bool HasValue, string Value) Name { get; }

        [Required]
        [Option("-v|--videoSource", "[Required] Url to video E.g. rtsp://server.example.org:8080/test.sdp", CommandOptionType.SingleValue)]
        public override (bool HasValue, string Value) VideoSource { get; }

        public AddCameraCmd(ICamerasRepository repository)
        {
            Repository = repository;
        }

        private ICamerasRepository Repository { get; }

        protected virtual async Task OnExecuteAsync(IConsole console)
        {
            if (!VideoSource.HasValue)
            {
                throw new ProcessingException("VideoSource is required property.");
            }

            if (!Name.HasValue)
            {
                throw new ProcessingException($"{nameof(Name)} is required property.");
            }

            var cameraRequestData = new CameraRequestData();
            
            SetBaseParameters(cameraRequestData);

            var result = await Repository.CreateCameraAsync(cameraRequestData);

            var resultOutput = JsonConvert.SerializeObject(result, Formatting.Indented);
            console.WriteLine(resultOutput);
        }
    }
}