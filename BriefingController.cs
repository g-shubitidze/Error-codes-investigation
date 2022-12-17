[HttpPost("Validate")]
public async Task<IActionResult> Validate([FromBody] BriefingValidationDto briefingValidationDto)
     => await this.HandleResponse(_briefingValidationAppService.ValidateAsync(briefingValidationDto));