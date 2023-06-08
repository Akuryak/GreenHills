using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GH.Model
{
    public partial class greenHillsContext : DbContext
    {
        public greenHillsContext()
        {
        }

        public greenHillsContext(DbContextOptions<greenHillsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Typecontract> Typecontracts { get; set; }
        public virtual DbSet<Typeobject> Typeobjects { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;database=greenHills;user=root;password=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PRIMARY");

                entity.ToTable("client");

                entity.HasIndex(e => e.Role, "role_idx");

                entity.Property(e => e.IdClient)
                    .ValueGeneratedNever()
                    .HasColumnName("id_client");

                entity.Property(e => e.EmailClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email_client");

                entity.Property(e => e.NameClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_client");

                entity.Property(e => e.PasswordClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password_client");

                entity.Property(e => e.PatronymicClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("patronymic_client");

                entity.Property(e => e.PhoneClient)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("phone_client");

                entity.Property(e => e.RequisitesClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("requisites_client");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.SurnameClient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("surname_client");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("role");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.IdContract)
                    .HasName("PRIMARY");

                entity.ToTable("contract");

                entity.HasIndex(e => e.IdByerContract, "idbyer_idx");

                entity.HasIndex(e => e.IdObjectContract, "idobjcon_idx");

                entity.HasIndex(e => e.IdStaffContract, "idstaffcon_idx");

                entity.HasIndex(e => e.TypeContract, "typecon_idx");

                entity.Property(e => e.IdContract)
                    .ValueGeneratedNever()
                    .HasColumnName("id_contract");

                entity.Property(e => e.DateConclusionContract)
                    .HasColumnType("date")
                    .HasColumnName("dateConclusion_contract");

                entity.Property(e => e.IdByerContract).HasColumnName("idByer_contract");

                entity.Property(e => e.IdObjectContract).HasColumnName("idObject_contract");

                entity.Property(e => e.IdStaffContract).HasColumnName("idStaff_contract");

                entity.Property(e => e.TypeContract).HasColumnName("type_contract");

                entity.Property(e => e.ValidUntilContract)
                    .HasColumnType("date")
                    .HasColumnName("validUntil_contract");

                entity.HasOne(d => d.IdByerContractNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.IdByerContract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idbyer");

                entity.HasOne(d => d.IdObjectContractNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.IdObjectContract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idobjcon");

                entity.HasOne(d => d.IdStaffContractNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.IdStaffContract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("idstaffcon");

                entity.HasOne(d => d.TypeContractNavigation)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.TypeContract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("typecon");
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.HasKey(e => e.IdObject)
                    .HasName("PRIMARY");

                entity.ToTable("object");

                entity.HasIndex(e => e.IdSobObject, "sobobject_idx");

                entity.HasIndex(e => e.TypeObject, "typeobject_idx");

                entity.Property(e => e.IdObject)
                    .ValueGeneratedNever()
                    .HasColumnName("id_object");

                entity.Property(e => e.AddressObject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address_object");

                entity.Property(e => e.CityObject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("city_object");

                entity.Property(e => e.DistrictObject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("district_object");

                entity.Property(e => e.FloorObject).HasColumnName("floor_object");

                entity.Property(e => e.IdSobObject).HasColumnName("idSob_object");

                entity.Property(e => e.ImagesObject)
                    .HasMaxLength(100)
                    .HasColumnName("images_object");

                entity.Property(e => e.LivingAreaObject)
                    .HasMaxLength(40)
                    .HasColumnName("livingArea_object");

                entity.Property(e => e.NumRoomsObject).HasColumnName("numRooms_object");

                entity.Property(e => e.PlotAreaObject)
                    .HasMaxLength(40)
                    .HasColumnName("plotArea_object");

                entity.Property(e => e.PriceObject)
                    .HasPrecision(19, 2)
                    .HasColumnName("price_object");

                entity.Property(e => e.TypeObject).HasColumnName("type_object");

                entity.HasOne(d => d.IdSobObjectNavigation)
                    .WithMany(p => p.Objects)
                    .HasForeignKey(d => d.IdSobObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sobobject");

                entity.HasOne(d => d.TypeObjectNavigation)
                    .WithMany(p => p.Objects)
                    .HasForeignKey(d => d.TypeObject)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("typeobject");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PRIMARY");

                entity.ToTable("role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("id_role");

                entity.Property(e => e.NameRole)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_role");
            });

            modelBuilder.Entity<Typecontract>(entity =>
            {
                entity.HasKey(e => e.IdTypeContract)
                    .HasName("PRIMARY");

                entity.ToTable("typecontract");

                entity.Property(e => e.IdTypeContract)
                    .ValueGeneratedNever()
                    .HasColumnName("id_typeContract");

                entity.Property(e => e.NameTypeContract)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_typeContract");
            });

            modelBuilder.Entity<Typeobject>(entity =>
            {
                entity.HasKey(e => e.IdTypeObject)
                    .HasName("PRIMARY");

                entity.ToTable("typeobject");

                entity.Property(e => e.IdTypeObject)
                    .ValueGeneratedNever()
                    .HasColumnName("id_typeObject");

                entity.Property(e => e.NameTypeObject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_typeObject");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.IdStaff)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.RoleStaff, "role_idx");

                entity.Property(e => e.IdStaff)
                    .ValueGeneratedNever()
                    .HasColumnName("id_staff");

                entity.Property(e => e.EmailStaff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email_staff");

                entity.Property(e => e.NameStaff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name_staff");

                entity.Property(e => e.PasswordStaf)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password_staf");

                entity.Property(e => e.PatronymicStaff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("patronymic_staff");

                entity.Property(e => e.PhoneStaff)
                    .HasColumnType("decimal(19,0) unsigned")
                    .HasColumnName("phone_staff");

                entity.Property(e => e.RequisitesStaff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("requisites_staff");

                entity.Property(e => e.RoleStaff).HasColumnName("role_staff");

                entity.Property(e => e.SurnameStaff)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("surname_staff");

                entity.HasOne(d => d.RoleStaffNavigation)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.RoleStaff)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rolestaff");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
