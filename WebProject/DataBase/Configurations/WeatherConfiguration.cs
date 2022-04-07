using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebProject.Domain.Models.WeatherTask;

namespace DBContexts.Configurations
{
    public class WeatherConfiguration
    {
        public void Configure(EntityTypeBuilder<WeatherDayView> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
            entityTypeBuilder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(200);
            entityTypeBuilder.Property(x => x.WeatherName)
                .IsRequired()
                .HasMaxLength(200);
            entityTypeBuilder.Property(x => x.WeatherShortDescription)
                .IsRequired()
                .HasMaxLength(200);
            entityTypeBuilder.Property(x => x.WeatherTemperature)
                .IsRequired();
            entityTypeBuilder.Property(x => x.WeatherTemperatureFeelsLikeCels)
                .IsRequired();
        }

    }
}
