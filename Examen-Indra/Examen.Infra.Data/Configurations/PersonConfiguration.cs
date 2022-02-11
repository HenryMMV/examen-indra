using Examen.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Infra.Data.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.LastName).HasMaxLength(200).IsUnicode(false).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(100).IsUnicode(false).IsRequired();
            builder.Property(p => p.Document).IsRequired();
            builder.Property(p => p.DocumentNumber).HasColumnType("CHAR(12)").IsRequired();
            builder.Property(p => p.Gender).IsRequired();
        }
    }
}
