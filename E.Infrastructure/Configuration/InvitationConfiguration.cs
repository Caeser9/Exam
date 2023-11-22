using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configuration
{
    public class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        {
            //FK
            builder.HasOne(i => i.Fete)
                .WithMany(f => f.Invitations)
                .HasForeignKey(f => f.FeteFk);

            builder.HasOne(i => i.Invite)
                .WithMany(ive => ive.Invitations)
                .HasForeignKey(ive => ive.InviteFk);

            //PK
            builder.HasKey(i=> new {
                i.Fete,
                i.Invite,
                i.DateInvitation
            });
        }
    }
}
