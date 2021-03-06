﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.0.12.0 (NJsonSchema v9.13.15.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace SmartFace.Api.Rpc
{
#pragma warning disable

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.12.0 (NJsonSchema v9.13.15.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class WatchlistItemsRpcClient
    {
        private string _baseUrl = "http://localhost:55220";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public WatchlistItemsRpcClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <param name="payload">JSON with WatchlistItem ExternalId (if item does not exist then it will be created), </br>
        /// ImageData with base64 encoded images of single face with MIME type, <br>
        /// Watchlist ExternalIds which will be linked to WatchlistItem (if watchlists do not exists then they will be created with default threshold).</param>
        /// <returns>NoContent</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FileResponse> RegisterAsync(RegisterWlItemData payload)
        {
            return RegisterAsync(payload, System.Threading.CancellationToken.None);
        }

        /// <param name="payload">JSON with WatchlistItem ExternalId (if item does not exist then it will be created), </br>
        /// ImageData with base64 encoded images of single face with MIME type, <br>
        /// Watchlist ExternalIds which will be linked to WatchlistItem (if watchlists do not exists then they will be created with default threshold).</param>
        /// <returns>NoContent</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FileResponse> RegisterAsync(RegisterWlItemData payload, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/rpc/WatchlistItems/Register");

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payload, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "204" || status_ == "206")
                        {
                            var responseStream_ = response_.Content == null ? System.IO.Stream.Null : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse_ = new FileResponse((int)response_.StatusCode, headers_, responseStream_, null, response_);
                            client_ = null; response_ = null; // response and client are disposed by FileResponse
                            return fileResponse_;
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FileResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Creates copy of Face entity by FaceId and this Face will be linked to WatchlistItem by WatchlistItemId.</summary>
        /// <param name="payload">JSON with FaceId and WatchlistItemId.</param>
        /// <returns>Creates copy of Face entity by FaceId and this Face will be linked to WatchlistItem by WatchlistItemId.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FileResponse> AddExistingFaceAsync(AddExistingFaceToWlItemData payload)
        {
            return AddExistingFaceAsync(payload, System.Threading.CancellationToken.None);
        }

        /// <summary>Creates copy of Face entity by FaceId and this Face will be linked to WatchlistItem by WatchlistItemId.</summary>
        /// <param name="payload">JSON with FaceId and WatchlistItemId.</param>
        /// <returns>Creates copy of Face entity by FaceId and this Face will be linked to WatchlistItem by WatchlistItemId.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FileResponse> AddExistingFaceAsync(AddExistingFaceToWlItemData payload, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/rpc/WatchlistItems/AddExistingFace");

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payload, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "204" || status_ == "206")
                        {
                            var responseStream_ = response_.Content == null ? System.IO.Stream.Null : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse_ = new FileResponse((int)response_.StatusCode, headers_, responseStream_, null, response_);
                            client_ = null; response_ = null; // response and client are disposed by FileResponse
                            return fileResponse_;
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FileResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>Remove Face from WatchlistItem specified by FaceId and WatchlistItemId.</summary>
        /// <param name="payload">JSON with FaceId and WatchlistItemId.</param>
        /// <returns>Remove Face from WatchlistItem specified by FaceId and WatchlistItemId.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<FileResponse> RemoveFaceAsync(RemoveExistingFaceFromWlItemData payload)
        {
            return RemoveFaceAsync(payload, System.Threading.CancellationToken.None);
        }

        /// <summary>Remove Face from WatchlistItem specified by FaceId and WatchlistItemId.</summary>
        /// <param name="payload">JSON with FaceId and WatchlistItemId.</param>
        /// <returns>Remove Face from WatchlistItem specified by FaceId and WatchlistItemId.</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async System.Threading.Tasks.Task<FileResponse> RemoveFaceAsync(RemoveExistingFaceFromWlItemData payload, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/rpc/WatchlistItems/RemoveFace");

            var client_ = _httpClient;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(payload, _settings.Value));
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = ((int)response_.StatusCode).ToString();
                        if (status_ == "204" || status_ == "206")
                        {
                            var responseStream_ = response_.Content == null ? System.IO.Stream.Null : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse_ = new FileResponse((int)response_.StatusCode, headers_, responseStream_, null, response_);
                            client_ = null; response_ = null; // response and client are disposed by FileResponse
                            return fileResponse_;
                        }
                        else
                        if (status_ != "200" && status_ != "204")
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                        }

                        return default(FileResponse);
                    }
                    finally
                    {
                        if (response_ != null)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
            }
        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is System.Enum)
            {
                string name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value;
                        }
                    }
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString(value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value != null && value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            return System.Convert.ToString(value, cultureInfo);
        }
    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.15.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RegisterWlItemData
    {
        [Newtonsoft.Json.JsonProperty("ExternalId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ExternalId { get; set; }

        [Newtonsoft.Json.JsonProperty("ImageData", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<RegisterWlItemImageData> ImageData { get; set; } = new System.Collections.ObjectModel.Collection<RegisterWlItemImageData>();

        [Newtonsoft.Json.JsonProperty("WatchlistExternalIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> WatchlistExternalIds { get; set; } = new System.Collections.ObjectModel.Collection<string>();

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RegisterWlItemData FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RegisterWlItemData>(data);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.15.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RegisterWlItemImageData
    {
        [Newtonsoft.Json.JsonProperty("Data", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public byte[] Data { get; set; }

        [Newtonsoft.Json.JsonProperty("MIME", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"image\/(png|jpeg)")]
        public string MIME { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RegisterWlItemImageData FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RegisterWlItemImageData>(data);
        }

    }

    /// <summary>Data required for adding cloned face to WatchlistItem.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.15.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class AddExistingFaceToWlItemData
    {
        /// <summary>FaceId to clone.</summary>
        [Newtonsoft.Json.JsonProperty("FaceId", Required = Newtonsoft.Json.Required.Always)]
        public long FaceId { get; set; }

        /// <summary>WatchlistItem Id that cloned face will be linked to.</summary>
        [Newtonsoft.Json.JsonProperty("WatchlistItemId", Required = Newtonsoft.Json.Required.Always)]
        public long WatchlistItemId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AddExistingFaceToWlItemData FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AddExistingFaceToWlItemData>(data);
        }

    }

    /// <summary>Data required for removing face from WatchlistItem.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.15.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RemoveExistingFaceFromWlItemData
    {
        /// <summary>FaceId to remove.</summary>
        [Newtonsoft.Json.JsonProperty("FaceId", Required = Newtonsoft.Json.Required.Always)]
        public long FaceId { get; set; }

        /// <summary>WatchlistItem Id that face should be removed from.</summary>
        [Newtonsoft.Json.JsonProperty("WatchlistItemId", Required = Newtonsoft.Json.Required.Always)]
        public long WatchlistItemId { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RemoveExistingFaceFromWlItemData FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RemoveExistingFaceFromWlItemData>(data);
        }

    }

    public partial class FileResponse : System.IDisposable
    {
        private System.IDisposable _client;
        private System.IDisposable _response;

        public int StatusCode { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public System.IO.Stream Stream { get; private set; }

        public bool IsPartial
        {
            get { return StatusCode == 206; }
        }

        public FileResponse(int statusCode, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.IO.Stream stream, System.IDisposable client, System.IDisposable response)
        {
            StatusCode = statusCode;
            Headers = headers;
            Stream = stream;
            _client = client;
            _response = response;
        }

        public void Dispose()
        {
            if (Stream != null)
                Stream.Dispose();
            if (_response != null)
                _response.Dispose();
            if (_client != null)
                _client.Dispose();
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.12.0 (NJsonSchema v9.13.15.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class SwaggerException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.12.0 (NJsonSchema v9.13.15.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

#pragma warning restore
}