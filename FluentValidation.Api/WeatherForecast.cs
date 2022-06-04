namespace FluentValidation.Api
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class WeatherForecastValidator : AbstractValidator<WeatherForecast>
    {
        public WeatherForecastValidator()
        {
            RuleFor(model => model.Summary).NotEmpty().WithMessage("Campo Requerido")
                                            .Length(5,10).WithMessage("Debe ingresar entre 5 y 10 caracteres");
            RuleFor(model => model.TemperatureC).LessThanOrEqualTo(500).WithMessage("Valor debe ser menor a 500");

        }
    }
}