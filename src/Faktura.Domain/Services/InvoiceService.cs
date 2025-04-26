using System;
using System.Threading.Tasks;
using Faktura.Domain.Configurations;
using Faktura.Domain.Constants;
using Faktura.Domain.Models;
using Flurl.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Polly;
using Polly.Retry;


namespace Faktura.Domain.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ILogger<InvoiceService> _logger;
        private readonly LikvidoConfig _likvidoConfig;
        private readonly AsyncRetryPolicy _retryPolicy;

        public InvoiceService(IOptions<LikvidoConfig> options,
            ILogger<InvoiceService> logger)
        {
            _logger = logger;
            _likvidoConfig = options.Value;

            _retryPolicy = Policy
                .Handle<FlurlHttpException>()
                .Or<FlurlHttpTimeoutException>()
                .WaitAndRetryAsync(3, retryAttempt =>
                {
                    var nextAttemptIn = TimeSpan.FromSeconds(Math.Pow(2, retryAttempt));
                    return nextAttemptIn;
                });
        }

        public async Task<CreateInvoiceResponseModel> CreateInvoice(CreateInvoiceRequestModel model)
        {
            try
            {
                var requestUrl = $"{_likvidoConfig.BaseApiUrl}{AppConstants.LikvidoCreateInvoiceEndpoint}";

                var response = await _retryPolicy.ExecuteAsync(() =>
                    requestUrl.WithHeader("X-ApiKey", _likvidoConfig.ApiKey)
                        .AllowAnyHttpStatus()
                        .PostJsonAsync(model)
                        .ReceiveJson<CreateInvoiceResponseModel>()
                );

                return response;
            }
            catch (FlurlHttpException ex)
            {
                _logger.LogError(ex, "An error occurred while creating new invoice");
            }

            return null;
        }

        public async Task<GetInvoicesResponseModel> GetInvoices(GetInvoicesFilterRequestModel model)
        {
            try
            {
                var requestUrl = $"{_likvidoConfig.BaseApiUrl}{AppConstants.LikvidoGetInvoiceListEndpoint}";

                var response = await _retryPolicy.ExecuteAsync(() =>
                    requestUrl.WithHeader("X-ApiKey", _likvidoConfig.ApiKey)
                        .SetQueryParams(model)
                        .GetJsonAsync<GetInvoicesResponseModel>()
                );

                return response;
            }
            catch (FlurlHttpException ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving invoices");
            }

            return null;
        }

        public async Task<GetInvoiceByIdResponseModel> GetInvoiceById(string id)
        {
            try
            {
                var requestUrl = string.Format($"{_likvidoConfig.BaseApiUrl}{AppConstants.LikvidoGetInvoiceByIdEndpoint}",
                    id);

                var response = await _retryPolicy.ExecuteAsync(() => requestUrl
                    .WithHeader("X-ApiKey", _likvidoConfig.ApiKey)
                    .GetJsonAsync<GetInvoiceByIdResponseModel>()
                );

                return response;
            }
            catch (FlurlHttpException ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving invoice");
            }

            return null;
        }
    }
}