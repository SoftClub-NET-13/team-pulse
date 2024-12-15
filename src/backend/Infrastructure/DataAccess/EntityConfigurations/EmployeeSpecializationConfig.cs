using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.EntityConfigurations;

public class EmployeeSpecializationConfig : IEntityTypeConfiguration<EmployeeSpecialization>
{
    public void Configure(EntityTypeBuilder<EmployeeSpecialization> builder)
    {
        builder.HasOne<Employee>().WithMany(x => x.EmployeeSpecializations).HasForeignKey(x=>x.EmployeeId);
        builder.HasOne<Specialization>().WithMany(x => x.EmployeeSpecializations).HasForeignKey(x=>x.SpecializationId);
        builder.HasAlternateKey(x => new { x.EmployeeId, x.SpecializationId });
    }
}