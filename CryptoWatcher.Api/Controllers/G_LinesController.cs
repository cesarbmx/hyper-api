﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CesarBmx.Shared.Application.Responses;
using CryptoWatcher.Application.Responses;
using CryptoWatcher.Application.Services;
using CryptoWatcher.Domain.Types;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CryptoWatcher.Api.Controllers
{
    [SwaggerResponse(500, Type = typeof(InternalServerErrorResponse))]
    [SwaggerResponse(401, Type = typeof(UnauthorizedResponse))]
    [SwaggerResponse(403, Type = typeof(ForbiddenResponse))]
    // ReSharper disable once InconsistentNaming
    public class G_LinesController : Controller
    {
        private readonly LineService _lineService;

        public G_LinesController(LineService lineService)
        {
            _lineService = lineService;
        }

        /// <summary>
        /// Get all lines
        /// </summary>
        [HttpGet]
        [Route("lines")]
        [SwaggerResponse(200, Type = typeof(List<LineResponse>))]
        [SwaggerOperation(Tags = new[] { "Lines" }, OperationId = "Lines_GetAllLines")]
        public async Task<IActionResult> GetAllLines(string currencyId = null, IndicatorType? indicatorType = null, string indicatorId = null, string userId = null)
        {
            // Reponse
            var response = await _lineService.GetAllLines(currencyId, indicatorType, indicatorId, userId);

            // Return
            return Ok(response);
        }
    }
}

