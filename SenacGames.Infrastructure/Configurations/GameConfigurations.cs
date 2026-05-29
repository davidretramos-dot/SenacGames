using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Configurations
{
    internal class GameConfigurations : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Title)
                .IsRequired() // Defina que o  campo é obrigatório
                .HasMaxLength(200); // Defina um tamanho máximo para o campo

            builder.Property(g => g.Description)
                .HasMaxLength(200); // Defina um tamanho máximo para o campo

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(200); // defina um tamanho máximo para o campo

            builder.HasOne(g => g.Category) // um game tem uma categoria
                .WithMany(c => c.Games) // uma categoria tem muitos games
                .HasForeignKey(g => g.CategoryId) // a FK é CategoryId
                .

        }
    }
}
