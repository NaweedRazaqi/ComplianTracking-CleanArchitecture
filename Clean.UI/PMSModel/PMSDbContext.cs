using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clean.UI.PMSModel
{
    public partial class PMSDbContext : DbContext
    {
        public PMSDbContext()
        {
        }

        public PMSDbContext(DbContextOptions<PMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountBatch> AccountBatch { get; set; }
        public virtual DbSet<AccountHolderType> AccountHolderType { get; set; }
        public virtual DbSet<AddOn> AddOn { get; set; }
        public virtual DbSet<AddOnPaymentType> AddOnPaymentType { get; set; }
        public virtual DbSet<AddOnRegulation> AddOnRegulation { get; set; }
        public virtual DbSet<AddOnSalaryType> AddOnSalaryType { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<ApplicationPayment> ApplicationPayment { get; set; }
        public virtual DbSet<ApplicationStatus> ApplicationStatus { get; set; }
        public virtual DbSet<ApplicationType> ApplicationType { get; set; }
        public virtual DbSet<Applicationlist> Applicationlist { get; set; }
        public virtual DbSet<Applicationlistid> Applicationlistid { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRolesScreens> AspNetRolesScreens { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUsersCategory> AspNetUsersCategory { get; set; }
        public virtual DbSet<AuditTrial> AuditTrial { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<BankAccountQueue> BankAccountQueue { get; set; }
        public virtual DbSet<BankBranches> BankBranches { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<BatchDetail> BatchDetail { get; set; }
        public virtual DbSet<BioData> BioData { get; set; }
        public virtual DbSet<BiometricCommittee> BiometricCommittee { get; set; }
        public virtual DbSet<BiometricHistory> BiometricHistory { get; set; }
        public virtual DbSet<Cadre> Cadre { get; set; }
        public virtual DbSet<CalculationType> CalculationType { get; set; }
        public virtual DbSet<Census> Census { get; set; }
        public virtual DbSet<ChartOfAccount> ChartOfAccount { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DataCategory> DataCategory { get; set; }
        public virtual DbSet<Dbobject> Dbobject { get; set; }
        public virtual DbSet<DbobjectObject> DbobjectObject { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Disability> Disability { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Due> Due { get; set; }
        public virtual DbSet<DueLog> DueLog { get; set; }
        public virtual DbSet<DueLogType> DueLogType { get; set; }
        public virtual DbSet<DueSurvivorLog> DueSurvivorLog { get; set; }
        public virtual DbSet<EducationDegree> EducationDegree { get; set; }
        public virtual DbSet<EducationRank> EducationRank { get; set; }
        public virtual DbSet<EmployeeRank> EmployeeRank { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<FiscalYear> FiscalYear { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Heir> Heir { get; set; }
        public virtual DbSet<HeirType> HeirType { get; set; }
        public virtual DbSet<M16> M16 { get; set; }
        public virtual DbSet<M16detail> M16detail { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<MultiplePension> MultiplePension { get; set; }
        public virtual DbSet<Nidaprovelist> Nidaprovelist { get; set; }
        public virtual DbSet<Nidpensionaprovedlist> Nidpensionaprovedlist { get; set; }
        public virtual DbSet<Nidverification> Nidverification { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OccurrenceType> OccurrenceType { get; set; }
        public virtual DbSet<OperationType> OperationType { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<OrganizationEmployee> OrganizationEmployee { get; set; }
        public virtual DbSet<OrganizationInfo> OrganizationInfo { get; set; }
        public virtual DbSet<OrganizationOrder> OrganizationOrder { get; set; }
        public virtual DbSet<OverPayment> OverPayment { get; set; }
        public virtual DbSet<OverPaymentDetail> OverPaymentDetail { get; set; }
        public virtual DbSet<OverPaymentType> OverPaymentType { get; set; }
        public virtual DbSet<PayGroupWise> PayGroupWise { get; set; }
        public virtual DbSet<PayGroupWiseOrganization> PayGroupWiseOrganization { get; set; }
        public virtual DbSet<PayGroupWiseQueue> PayGroupWiseQueue { get; set; }
        public virtual DbSet<PayGroupWiseRank> PayGroupWiseRank { get; set; }
        public virtual DbSet<Payable> Payable { get; set; }
        public virtual DbSet<PayableDetails> PayableDetails { get; set; }
        public virtual DbSet<Payablelistid> Payablelistid { get; set; }
        public virtual DbSet<PaymentCategory> PaymentCategory { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PaymentTypeInterval> PaymentTypeInterval { get; set; }
        public virtual DbSet<PensionCardTypes> PensionCardTypes { get; set; }
        public virtual DbSet<PensionCards> PensionCards { get; set; }
        public virtual DbSet<PensionDisability> PensionDisability { get; set; }
        public virtual DbSet<PensionType> PensionType { get; set; }
        public virtual DbSet<PositionType> PositionType { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<ProcessConnection> ProcessConnection { get; set; }
        public virtual DbSet<ProcessTracking> ProcessTracking { get; set; }
        public virtual DbSet<Professional> Professional { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileCode> ProfileCode { get; set; }
        public virtual DbSet<ProfileList> ProfileList { get; set; }
        public virtual DbSet<Profilelist1> Profilelist1 { get; set; }
        public virtual DbSet<Profilelistid> Profilelistid { get; set; }
        public virtual DbSet<ProvencialProfile> ProvencialProfile { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Rank> Rank { get; set; }
        public virtual DbSet<ReEmployment> ReEmployment { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<Regulation> Regulation { get; set; }
        public virtual DbSet<RegulationRank> RegulationRank { get; set; }
        public virtual DbSet<Relative> Relative { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<RetirementRegulation> RetirementRegulation { get; set; }
        public virtual DbSet<Right> Right { get; set; }
        public virtual DbSet<SalaryCycle> SalaryCycle { get; set; }
        public virtual DbSet<SalaryType> SalaryType { get; set; }
        public virtual DbSet<Screen> Screen { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<ServiceCadre> ServiceCadre { get; set; }
        public virtual DbSet<ServiceDetail> ServiceDetail { get; set; }
        public virtual DbSet<ServiceProfessional> ServiceProfessional { get; set; }
        public virtual DbSet<ServiceRecord> ServiceRecord { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Status1> Status1 { get; set; }
        public virtual DbSet<Survivor> Survivor { get; set; }
        public virtual DbSet<SurvivorStatus> SurvivorStatus { get; set; }
        public virtual DbSet<Tableinfo> Tableinfo { get; set; }
        public virtual DbSet<Token> Token { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<WorkType> WorkType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost; port=5432; Database=PMS; Username=postgres; Password=newmOOn@16;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBatch>(entity =>
            {
                entity.ToTable("AccountBatch", "prf");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_accountbatch_applicationid");

                entity.HasIndex(e => e.BatchId)
                    .HasName("i_accountbatch_batchid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.accountbatch_seq'::regclass)");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AccountBatch)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccBatch_ApplicationID");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.AccountBatch)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccBatch_BatchID");
            });

            modelBuilder.Entity<AccountHolderType>(entity =>
            {
                entity.ToTable("AccountHolderType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AddOn>(entity =>
            {
                entity.ToTable("AddOn", "cal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.addon_seq'::regclass)");

                entity.Property(e => e.AddOnPaymentTypeId).HasColumnName("AddOnPaymentTypeID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.AddOnPaymentType)
                    .WithMany(p => p.AddOn)
                    .HasForeignKey(d => d.AddOnPaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOn_AddOnPayementType");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.AddOn)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_AddOn_Organization");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.AddOn)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK_AddOn_Rank");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.AddOn)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOn_Status");
            });

            modelBuilder.Entity<AddOnPaymentType>(entity =>
            {
                entity.ToTable("AddOnPaymentType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<AddOnRegulation>(entity =>
            {
                entity.HasKey(e => new { e.AddOnId, e.RegulationId })
                    .HasName("AddOnRegulation_pkey");

                entity.ToTable("AddOnRegulation", "cal");

                entity.Property(e => e.AddOnId).HasColumnName("AddOnID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.HasOne(d => d.AddOn)
                    .WithMany(p => p.AddOnRegulation)
                    .HasForeignKey(d => d.AddOnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOnRegulation_AddOn");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.AddOnRegulation)
                    .HasForeignKey(d => d.RegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOnRegulation_Regulation");
            });

            modelBuilder.Entity<AddOnSalaryType>(entity =>
            {
                entity.HasKey(e => new { e.AddOnId, e.SalaryTypeId })
                    .HasName("pk__addonsal__4e5f4dadbd7ccc3a");

                entity.ToTable("AddOnSalaryType", "cal");

                entity.Property(e => e.AddOnId).HasColumnName("AddOnID");

                entity.Property(e => e.SalaryTypeId).HasColumnName("SalaryTypeID");

                entity.HasOne(d => d.AddOn)
                    .WithMany(p => p.AddOnSalaryType)
                    .HasForeignKey(d => d.AddOnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOnSalaryType_AddOn");

                entity.HasOne(d => d.SalaryType)
                    .WithMany(p => p.AddOnSalaryType)
                    .HasForeignKey(d => d.SalaryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddOnSalatyType_SalatyType");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_address_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.address_seq'::regclass)");

                entity.Property(e => e.CurrentDistrictId).HasColumnName("CurrentDistrictID");

                entity.Property(e => e.CurrentProvinceId).HasColumnName("CurrentProvinceID");

                entity.Property(e => e.CurrentVillage).HasMaxLength(120);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.HolderTypeId).HasColumnName("HolderTypeID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RelativeTelephoneNo).HasMaxLength(200);

                entity.Property(e => e.TelephonNo).HasMaxLength(100);

                entity.Property(e => e.Village).HasMaxLength(120);

                entity.HasOne(d => d.CurrentDistrict)
                    .WithMany(p => p.AddressCurrentDistrict)
                    .HasForeignKey(d => d.CurrentDistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppAddress_CurrentDistrictID");

                entity.HasOne(d => d.CurrentProvince)
                    .WithMany(p => p.AddressCurrentProvince)
                    .HasForeignKey(d => d.CurrentProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppAddress_CurrentProvinceID");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AddressDistrict)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AppAddress_DistrictID");

                entity.HasOne(d => d.HolderType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.HolderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AccountHolderType");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Profile");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.AddressProvince)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppAddress_ProvinceID");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application", "prf");

                entity.HasIndex(e => e.CurrentProcess)
                    .HasName("current_process_ix");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("profile_id_ix");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.application_seq'::regclass)");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ApplicationTypeId).HasColumnName("ApplicationTypeID");

                entity.Property(e => e.CalCulationStartDate).HasColumnType("date");

                entity.Property(e => e.CardIssuancePlaceId).HasColumnName("CardIssuancePlaceID");

                entity.Property(e => e.DataCategoryId).HasColumnName("DataCategoryID");

                entity.Property(e => e.DecreeDate).HasColumnType("date");

                entity.Property(e => e.DecreeNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.LastDayOfEmployment).HasColumnType("date");

                entity.Property(e => e.PhotoPath).HasMaxLength(500);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.Property(e => e.RetirmentStartDate).HasColumnType("date");

                entity.HasOne(d => d.ApplicationType)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ApplicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_ApplicationType");

                entity.HasOne(d => d.CardIssuancePlace)
                    .WithMany(p => p.ApplicationCardIssuancePlace)
                    .HasForeignKey(d => d.CardIssuancePlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Application_Province");

                entity.HasOne(d => d.DataCategory)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.DataCategoryId)
                    .HasConstraintName("FK_Application_DataCategoryID");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_App_District");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applicant_Profile");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.ApplicationProvince)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_App_ProvinceID");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.RegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_App_Regulation");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Application)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applicant_Status");
            });

            modelBuilder.Entity<ApplicationPayment>(entity =>
            {
                entity.ToTable("ApplicationPayment", "pa");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_applicationpayment_applicationid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationPayment)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationPayment_Application");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.ApplicationPayment)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationPayment_FiscalYear");
            });

            modelBuilder.Entity<ApplicationStatus>(entity =>
            {
                entity.ToTable("ApplicationStatus", "prf");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_applicationstatus_applicationid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationStatus)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_applicationid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ApplicationStatus)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_ApplicationStatus_Status");
            });

            modelBuilder.Entity<ApplicationType>(entity =>
            {
                entity.ToTable("ApplicationType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Applicationlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("applicationlist");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");
            });

            modelBuilder.Entity<Applicationlistid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("applicationlistid");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("ix_aspnetroleclaims_roleid");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('aspnetroleclaims_seq'::regclass)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("rolenameindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('aspnetroles_seq'::regclass)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRolesScreens>(entity =>
            {
                entity.ToTable("AspNetRoles_Screens");

                entity.HasIndex(e => new { e.RoleId, e.ScreenId })
                    .HasName("uq_roles_screens")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('aspnetroles_screens_seq'::regclass)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("true");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("ix_aspnetuserclaims_userid");

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('aspnetuserclaims_seq'::regclass)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("pk_aspnetuserlogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("ix_aspnetuserlogins_userid");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.ProviderKey).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("pk_aspnetuserroles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("ix_aspnetuserroles_roleid");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("pk_aspnetusertokens");

                entity.Property(e => e.LoginProvider).HasMaxLength(450);

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("emailindex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("usernameindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("nextval('aspnetusers_seq'::regclass)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.UserCategoryId).HasColumnName("UserCategoryID");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.UserProcessId).HasColumnName("UserProcessID");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_ProvinceID");
            });

            modelBuilder.Entity<AspNetUsersCategory>(entity =>
            {
                entity.ToTable("AspNetUsers_Category");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('aspnetusers_category_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameEng).HasMaxLength(100);
            });

            modelBuilder.Entity<AuditTrial>(entity =>
            {
                entity.ToTable("AuditTrial", "au");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('au.audittrial_seq'::regclass)");

                entity.Property(e => e.DbContextObject).HasMaxLength(100);

                entity.Property(e => e.DbObjectName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OperationDate).HasDefaultValueSql("now()");

                entity.Property(e => e.OperationTypeId).HasColumnName("OperationTypeID");

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasColumnName("RecordID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.OperationType)
                    .WithMany(p => p.AuditTrial)
                    .HasForeignKey(d => d.OperationTypeId)
                    .HasConstraintName("FK_AuditOperationType");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.ToTable("BankAccount", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_bankaccount_profileid");

                entity.HasIndex(e => new { e.AccountNumber, e.BranchId })
                    .HasName("uq_bankaccount");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.bankaccount_seq'::regclass)");

                entity.Property(e => e.AccountHolderTypeId).HasColumnName("AccountHolderTypeID");

                entity.Property(e => e.AccountNumber).HasMaxLength(150);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.AccountHolderType)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.AccountHolderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountHolderType_AccountHolderTypeID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BankAccount_BranchId_fkey");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankAccount_Profile");
            });

            modelBuilder.Entity<BankAccountQueue>(entity =>
            {
                entity.HasKey(e => e.ProfileId)
                    .HasName("BankAccountQueue_pkey");

                entity.ToTable("BankAccountQueue", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_bankaccountqueue_profileid");

                entity.Property(e => e.ProfileId)
                    .HasColumnName("ProfileID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<BankBranches>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("pk__bankbran__a1682fc5ade460d8");

                entity.ToTable("BankBranches", "look");

                entity.Property(e => e.BranchId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankBranches)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BankBranches_BankId_fkey");
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("pk__banks__aa08cb1389db63f8");

                entity.ToTable("Banks", "look");

                entity.Property(e => e.BankId).ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch", "pa");

                entity.HasIndex(e => e.Code)
                    .HasName("i_batch_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('pa.batch_seq'::regclass)");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BatchTypeId).HasColumnName("BatchTypeID");

                entity.Property(e => e.Code).HasMaxLength(60);

                entity.Property(e => e.DataCategoryId).HasColumnName("DataCategoryID");

                entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.OccurrenceTypeId).HasColumnName("OccurrenceTypeID");

                entity.Property(e => e.PaymentTypeIntervalId).HasColumnName("PaymentTypeIntervalID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Batch_BankID");

                entity.HasOne(d => d.CoANavigation)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.CoA)
                    .HasConstraintName("FK_Batch_coa");

                entity.HasOne(d => d.DataCategory)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.DataCategoryId)
                    .HasConstraintName("FK_Batch_DataCatery");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Batch_FiscalYear");

                entity.HasOne(d => d.OccurrenceType)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.OccurrenceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Batch_OccurrenceType");

                entity.HasOne(d => d.PaymentTypeInterval)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.PaymentTypeIntervalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Batch_PaymentTypeInterval");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Batch)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Batch_Status");
            });

            modelBuilder.Entity<BatchDetail>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("pk_batchdetail_batchid");

                entity.ToTable("BatchDetail", "pa");

                entity.HasIndex(e => e.BatchId)
                    .HasName("i_batchdetail_batchid")
                    .IsUnique();

                entity.Property(e => e.BatchId)
                    .HasColumnName("BatchID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.HasOne(d => d.Batch)
                    .WithOne(p => p.BatchDetail)
                    .HasForeignKey<BatchDetail>(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BatchDetail_BatchIDF");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.BatchDetail)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BatchDetail_PaymentType");
            });

            modelBuilder.Entity<BioData>(entity =>
            {
                entity.ToTable("BioData", "prf");

                entity.HasIndex(e => e.Nidnumber)
                    .HasName("i_biodata_nidnumber");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FatherName).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.GrandFatherName).HasMaxLength(150);

                entity.Property(e => e.HashKey)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.Nidnumber)
                    .HasColumnName("NIDNumber")
                    .HasMaxLength(150);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BiometricCommittee>(entity =>
            {
                entity.ToTable("BiometricCommittee", "au");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Decision).HasMaxLength(500);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.BiometricCommittee)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Committee_Profile");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.BiometricCommittee)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Committee_LookStatus");
            });

            modelBuilder.Entity<BiometricHistory>(entity =>
            {
                entity.ToTable("BiometricHistory", "bio");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BioDataId).HasColumnName("BioDataID");

                entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");

                entity.Property(e => e.IsNidmatched).HasColumnName("IsNIDMatched");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.BioData)
                    .WithMany(p => p.BiometricHistory)
                    .HasForeignKey(d => d.BioDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiometricHistory_BioData");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.BiometricHistory)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiometricHistory_FiscalYear");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.BiometricHistory)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BiometricHistory_Profile");
            });

            modelBuilder.Entity<Cadre>(entity =>
            {
                entity.ToTable("Cadre", "cal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.cadre_seq'::regclass)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EducationRankId).HasColumnName("EducationRankID");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.Property(e => e.SalaryTypeId).HasColumnName("SalaryTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Cadre_Department");

                entity.HasOne(d => d.EducationRank)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.EducationRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cadre_EducationRank");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Cadre_Organization");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.RegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cadre_Regulation");

                entity.HasOne(d => d.SalaryType)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.SalaryTypeId)
                    .HasConstraintName("FK_Cadre_SalaryType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Cadre)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cadre_Status");
            });

            modelBuilder.Entity<CalculationType>(entity =>
            {
                entity.ToTable("CalculationType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Census>(entity =>
            {
                entity.ToTable("Census", "pd");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('pd.census1_id_seq'::regclass)");

                entity.Property(e => e.Accountname)
                    .HasColumnName("accountname")
                    .HasMaxLength(100);

                entity.Property(e => e.Accountnumber)
                    .HasColumnName("accountnumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Adjustmentdate)
                    .HasColumnName("adjustmentdate")
                    .HasColumnType("date");

                entity.Property(e => e.Applang)
                    .HasColumnName("applang")
                    .HasMaxLength(50);

                entity.Property(e => e.Bankbranchid1).HasColumnName("bankbranchid1");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Benfathername)
                    .HasColumnName("benfathername")
                    .HasMaxLength(200);

                entity.Property(e => e.Benname)
                    .HasColumnName("benname")
                    .HasMaxLength(200);

                entity.Property(e => e.Censusdate)
                    .HasColumnName("censusdate")
                    .HasColumnType("date");

                entity.Property(e => e.Chequeno)
                    .HasColumnName("chequeno")
                    .HasMaxLength(20);

                entity.Property(e => e.Createuser).HasColumnName("createuser");

                entity.Property(e => e.Datecreated).HasColumnName("datecreated");

                entity.Property(e => e.Datemodified).HasColumnName("datemodified");

                entity.Property(e => e.Dateofassignment)
                    .HasColumnName("dateofassignment")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("dateofbirth")
                    .HasColumnType("date");

                entity.Property(e => e.Dateofworkstart)
                    .HasColumnName("dateofworkstart")
                    .HasColumnType("date");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Enddateofassignment)
                    .HasColumnName("enddateofassignment")
                    .HasColumnType("date");

                entity.Property(e => e.Fathername)
                    .HasColumnName("fathername")
                    .HasMaxLength(200);

                entity.Property(e => e.Fingerprint)
                    .HasColumnName("fingerprint")
                    .HasMaxLength(200);

                entity.Property(e => e.Firstbenefit)
                    .HasColumnName("firstbenefit")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Formid2).HasColumnName("formid2");

                entity.Property(e => e.Gfathername)
                    .HasColumnName("gfathername")
                    .HasMaxLength(200);

                entity.Property(e => e.Gradid).HasColumnName("gradid");

                entity.Property(e => e.Hasmorewakeel).HasColumnName("hasmorewakeel");

                entity.Property(e => e.Isexported).HasColumnName("isexported");

                entity.Property(e => e.Issurvivor).HasColumnName("issurvivor");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(100);

                entity.Property(e => e.Kindofbenefit)
                    .HasColumnName("kindofbenefit")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastmodifyuser).HasColumnName("lastmodifyuser");

                entity.Property(e => e.Lawofretirement)
                    .HasColumnName("lawofretirement")
                    .HasMaxLength(100);

                entity.Property(e => e.Loansdebts)
                    .HasColumnName("loansdebts")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Maritalstatus)
                    .HasColumnName("maritalstatus")
                    .HasMaxLength(50);

                entity.Property(e => e.Mem12number).HasColumnName("mem12number");

                entity.Property(e => e.Monthlybenefit)
                    .HasColumnName("monthlybenefit")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Monthlytotal)
                    .HasColumnName("monthlytotal")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(200);

                entity.Property(e => e.Organizationid).HasColumnName("organizationid");

                entity.Property(e => e.Paidmoreyears).HasColumnName("paidmoreyears");

                entity.Property(e => e.Payamount)
                    .HasColumnName("payamount")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Paydate)
                    .HasColumnName("paydate")
                    .HasColumnType("date");

                entity.Property(e => e.Paymentamount)
                    .HasColumnName("paymentamount")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Pensionbeneficiary)
                    .HasColumnName("pensionbeneficiary")
                    .HasMaxLength(200);

                entity.Property(e => e.Pensionbookno)
                    .HasColumnName("pensionbookno")
                    .HasMaxLength(50);

                entity.Property(e => e.Pensionercensusid).HasColumnName("pensionercensusid");

                entity.Property(e => e.Pensionerno)
                    .HasColumnName("pensionerno")
                    .HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasMaxLength(200);

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(50);

                entity.Property(e => e.Placeofbirth)
                    .HasColumnName("placeofbirth")
                    .HasMaxLength(100);

                entity.Property(e => e.Placeofwork).HasColumnName("placeofwork");

                entity.Property(e => e.Rejectcount).HasColumnName("rejectcount");

                entity.Property(e => e.Rejected).HasColumnName("rejected");

                entity.Property(e => e.Relationid).HasColumnName("relationid");

                entity.Property(e => e.Retirementdate)
                    .HasColumnName("retirementdate")
                    .HasColumnType("date");

                entity.Property(e => e.Retirementreason)
                    .HasColumnName("retirementreason")
                    .HasMaxLength(200);

                entity.Property(e => e.Scannedimg)
                    .HasColumnName("scannedimg")
                    .HasMaxLength(200);

                entity.Property(e => e.Scheme)
                    .HasColumnName("scheme")
                    .HasMaxLength(100);

                entity.Property(e => e.Signature)
                    .HasColumnName("signature")
                    .HasMaxLength(50);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Taskraid)
                    .HasColumnName("taskraid")
                    .HasMaxLength(50);

                entity.Property(e => e.Totalamount)
                    .HasColumnName("totalamount")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Totalservicelength)
                    .HasColumnName("totalservicelength")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Transfertoprovince).HasColumnName("transfertoprovince");

                entity.Property(e => e.Transfertoprovinceid).HasColumnName("transfertoprovinceid");

                entity.Property(e => e.Wakalatnumber)
                    .HasColumnName("wakalatnumber")
                    .HasMaxLength(200);

                entity.Property(e => e.Yearlybenefit)
                    .HasColumnName("yearlybenefit")
                    .HasColumnType("numeric(18,0)");
            });

            modelBuilder.Entity<ChartOfAccount>(entity =>
            {
                entity.ToTable("ChartOfAccount", "pa");

                entity.HasIndex(e => e.Code)
                    .HasName("i_chartofaccount_code");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.DataCategoryId).HasColumnName("DataCategoryID");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.IdentifierEnglish).HasMaxLength(120);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.HasOne(d => d.DataCategory)
                    .WithMany(p => p.ChartOfAccount)
                    .HasForeignKey(d => d.DataCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChartOfAccount_CateryID");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.ChartOfAccount)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .HasConstraintName("FK_ChartOfAccount_ServiceType");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("character varying");

                entity.Property(e => e.TitleEn)
                    .IsRequired()
                    .HasColumnName("TitleEN")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<DataCategory>(entity =>
            {
                entity.ToTable("DataCategory", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LivingStatusId).HasColumnName("LivingStatusID");

                entity.Property(e => e.Type).HasMaxLength(32);

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.DataCategory)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK_DataCatery_EmployeeTypeID");

                entity.HasOne(d => d.LivingStatus)
                    .WithMany(p => p.DataCategory)
                    .HasForeignKey(d => d.LivingStatusId)
                    .HasConstraintName("FK_LivingStatus");
            });

            modelBuilder.Entity<Dbobject>(entity =>
            {
                entity.ToTable("DBObject", "rep");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dbname).HasColumnName("DBName");

                entity.Property(e => e.Fkey).HasColumnName("FKey");

                entity.Property(e => e.Pkey).HasColumnName("PKey");
            });

            modelBuilder.Entity<DbobjectObject>(entity =>
            {
                entity.ToTable("DBObjectObject", "rep");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChildId).HasColumnName("ChildID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.department_seq'::regclass)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NamePashto).HasMaxLength(100);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            });

            modelBuilder.Entity<Disability>(entity =>
            {
                entity.ToTable("Disability", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Decription).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District", "look");

                entity.Property(e => e.DistrictId)
                    .HasColumnName("DistrictID")
                    .HasDefaultValueSql("nextval('look.district_seq'::regclass)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DistrictName).HasMaxLength(200);

                entity.Property(e => e.DistrictNameDari).HasMaxLength(200);

                entity.Property(e => e.DistrictNamePashto).HasMaxLength(200);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.document_seq'::regclass)");

                entity.Property(e => e.ContentType).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.DocumentSource).HasMaxLength(50);

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.EncryptionKey).HasMaxLength(120);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.ObjectName).HasMaxLength(3);

                entity.Property(e => e.ObjectSchema).HasMaxLength(20);

                entity.Property(e => e.Path).HasMaxLength(300);

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasColumnType("numeric(18,0)");

                entity.Property(e => e.Root).HasMaxLength(3000);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .HasConstraintName("Fk_DocumentType_DocumentTypeID");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.ScreenId)
                    .HasConstraintName("FK_Screen_ScreenID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_SatatusLOOK_StatusID");
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catagory)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Due>(entity =>
            {
                entity.ToTable("Due", "pa");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_due_applicationid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('pa.due_seq'::regclass)");

                entity.Property(e => e.Amount).HasColumnType("numeric(15,2)");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.Percentage).HasColumnType("numeric(5,2)");

                entity.HasOne(d => d.Application)
                    .WithOne(p => p.Due)
                    .HasForeignKey<Due>(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Due_ApplicationID");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Due)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Due_PaymentTypeID");
            });

            modelBuilder.Entity<DueLog>(entity =>
            {
                entity.ToTable("DueLog", "pa");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddOnId).HasColumnName("AddOnID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.DueLogTypeId).HasColumnName("DueLogTypeID");

                entity.HasOne(d => d.AddOn)
                    .WithMany(p => p.DueLog)
                    .HasForeignKey(d => d.AddOnId)
                    .HasConstraintName("FK_Due_AddOnID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.DueLog)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Due_Application");

                entity.HasOne(d => d.DueLogType)
                    .WithMany(p => p.DueLog)
                    .HasForeignKey(d => d.DueLogTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Due_DueLogType");
            });

            modelBuilder.Entity<DueLogType>(entity =>
            {
                entity.ToTable("DueLogType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DueSurvivorLog>(entity =>
            {
                entity.ToTable("DueSurvivorLog", "pa");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DueLogId).HasColumnName("DueLogID");

                entity.HasOne(d => d.DueLog)
                    .WithMany(p => p.DueSurvivorLog)
                    .HasForeignKey(d => d.DueLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DueSurvivor_DueLog");
            });

            modelBuilder.Entity<EducationDegree>(entity =>
            {
                entity.HasKey(e => e.DegreeId)
                    .HasName("pk__educatio__4d9492ce0b5b07be");

                entity.ToTable("EducationDegree", "look");

                entity.Property(e => e.DegreeId)
                    .HasColumnName("DegreeID")
                    .HasDefaultValueSql("nextval('look.educationdegree_seq'::regclass)");

                entity.Property(e => e.Category)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.DegreeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DegreeNameDari)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EducationRank>(entity =>
            {
                entity.ToTable("EducationRank", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeRank>(entity =>
            {
                entity.ToTable("EmployeeRank", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.IdentifierDari)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IdentifierEnglish).HasMaxLength(100);

                entity.Property(e => e.IdentifierPashto).HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EmployeeType", "look");

                entity.Property(e => e.EmployeeTypeId)
                    .HasColumnName("EmployeeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FiscalYear>(entity =>
            {
                entity.ToTable("FiscalYear", "pa");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('pa.fiscalyear_seq'::regclass)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Forms>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("pk__forms__fb05b7bdeefee9fa");

                entity.ToTable("Forms", "re");

                entity.Property(e => e.FormId)
                    .HasColumnName("FormID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender", "look");

                entity.Property(e => e.GenderId)
                    .HasColumnName("GenderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GenderNameDari)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Heir>(entity =>
            {
                entity.ToTable("Heir", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_heir_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.heir_seq'::regclass)");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Court)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.DocNoIssueDate).HasColumnType("date");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GrandFatherName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.HeirTypeId).HasColumnName("HeirTypeID");

                entity.Property(e => e.LastName).HasMaxLength(120);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(200);

                entity.Property(e => e.PhotoPath)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RelativeId).HasColumnName("RelativeID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fk_country-id");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppHeir_DocumentTypeID");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppHeir_Gender");

                entity.HasOne(d => d.HeirType)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.HeirTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeirTypeID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppHeir_Profile");

                entity.HasOne(d => d.Relative)
                    .WithMany(p => p.Heir)
                    .HasForeignKey(d => d.RelativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppHeir_Relative");
            });

            modelBuilder.Entity<HeirType>(entity =>
            {
                entity.ToTable("HeirType", "look");

                entity.Property(e => e.HeirTypeId)
                    .HasColumnName("HeirTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HeirName).HasMaxLength(100);
            });

            modelBuilder.Entity<M16>(entity =>
            {
                entity.ToTable("M16", "pa");

                entity.HasIndex(e => e.Code)
                    .HasName("i_m16_code");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.ChequeDate).HasColumnType("date");

                entity.Property(e => e.ChequeNo).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(60);

                entity.Property(e => e.M12recievedDate)
                    .HasColumnName("M12RecievedDate")
                    .HasColumnType("date");

                entity.Property(e => e.M16issueDate)
                    .HasColumnName("M16IssueDate")
                    .HasColumnType("date");

                entity.Property(e => e.M16submittedToMoFdate)
                    .HasColumnName("M16submittedToMoFDate")
                    .HasColumnType("date");

                entity.Property(e => e.SequenceNumber).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TransferDate).HasColumnType("date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.M16)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_statusid");
            });

            modelBuilder.Entity<M16detail>(entity =>
            {
                entity.ToTable("M16Detail", "pa");

                entity.HasIndex(e => e.M16id)
                    .HasName("i_m16detail_code");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.M16id).HasColumnName("M16ID");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.M16detail)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_batchid");

                entity.HasOne(d => d.M16)
                    .WithMany(p => p.M16detail)
                    .HasForeignKey(d => d.M16id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_m16id");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.ToTable("MaritalStatus", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.module_seq'::regclass)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NameE).HasMaxLength(200);
            });

            modelBuilder.Entity<MultiplePension>(entity =>
            {
                entity.ToTable("MultiplePension", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_multiplepension_profileid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeirId).HasColumnName("HeirID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Heir)
                    .WithMany(p => p.MultiplePension)
                    .HasForeignKey(d => d.HeirId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultiplePension_Heir");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MultiplePension)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultiplePension_Profile");
            });

            modelBuilder.Entity<Nidaprovelist>(entity =>
            {
                entity.ToTable("nidaprovelist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID");

                entity.Property(e => e.PensionFatherName).HasMaxLength(100);

                entity.Property(e => e.PensionName).HasMaxLength(100);
            });

            modelBuilder.Entity<Nidpensionaprovedlist>(entity =>
            {
                entity.ToTable("nidpensionaprovedlist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID");
            });

            modelBuilder.Entity<Nidverification>(entity =>
            {
                entity.ToTable("NIDVerification", "au");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("Notifications", "notify");

                entity.HasIndex(e => e.AppUserId)
                    .HasName("fki_AppUserID_foriegnKey");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .HasMaxLength(255);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OccurrenceType>(entity =>
            {
                entity.ToTable("OccurrenceType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(32);

                entity.Property(e => e.Condition).HasMaxLength(20);

                entity.Property(e => e.DbOjbect).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EnglishIdentifier)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OperationType>(entity =>
            {
                entity.ToTable("OperationType", "au");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.organization_seq'::regclass)");

                entity.Property(e => e.Abbreviation).HasMaxLength(32);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(132);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(132);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Pashto)
                    .IsRequired()
                    .HasMaxLength(132);
            });

            modelBuilder.Entity<OrganizationEmployee>(entity =>
            {
                entity.ToTable("OrganizationEmployee", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.OrganizationEmployee)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_employeetype");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationEmployee)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_organizationid");
            });

            modelBuilder.Entity<OrganizationInfo>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .HasName("pk__organiza__cadb0b7284771537");

                entity.ToTable("OrganizationInfo", "look");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("OrganizationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Phone).HasMaxLength(32);

                entity.HasOne(d => d.Organization)
                    .WithOne(p => p.OrganizationInfo)
                    .HasForeignKey<OrganizationInfo>(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationID");
            });

            modelBuilder.Entity<OrganizationOrder>(entity =>
            {
                entity.ToTable("OrganizationOrder", "pa");

                entity.HasIndex(e => e.FiscalYearId)
                    .HasName("i_organization_fiscalyearid");

                entity.HasIndex(e => e.OrganizationId)
                    .HasName("i_organization_organizationid");

                entity.HasIndex(e => new { e.OrganizationId, e.FiscalYearId })
                    .HasName("uq_organizationorder_organization_year")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('pa.organizationorder_seq'::regclass)");

                entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.OrganizationOrder)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationOrder_FiscalYearID");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationOrder)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationOrder_OrganizationID");
            });

            modelBuilder.Entity<OverPayment>(entity =>
            {
                entity.ToTable("OverPayment", "pa");

                entity.HasIndex(e => new { e.ProfileId, e.ApplicationId })
                    .HasName("i_overpayment_profileid_applicatoinid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.OverPaidAmount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.OverPaymentTypeId).HasColumnName("OverPaymentTypeID");

                entity.Property(e => e.PaidAmount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.PaymentCategoryId).HasColumnName("PaymentCategoryID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.OverPayment)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverPayment_Application");

                entity.HasOne(d => d.OverPaymentType)
                    .WithMany(p => p.OverPayment)
                    .HasForeignKey(d => d.OverPaymentTypeId)
                    .HasConstraintName("fk_overpayment_overpaymenttype");

                entity.HasOne(d => d.PaymentCategory)
                    .WithMany(p => p.OverPayment)
                    .HasForeignKey(d => d.PaymentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverPayment_PaymentCategory");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.OverPayment)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_overpayment_profile");
            });

            modelBuilder.Entity<OverPaymentDetail>(entity =>
            {
                entity.ToTable("OverPaymentDetail", "pa");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.OverPaymentId).HasColumnName("OverPaymentID");

                entity.Property(e => e.PayableId).HasColumnName("PayableID");

                entity.HasOne(d => d.OverPayment)
                    .WithMany(p => p.OverPaymentDetail)
                    .HasForeignKey(d => d.OverPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverPaymentDetail_OverPayment");

                entity.HasOne(d => d.Payable)
                    .WithMany(p => p.OverPaymentDetail)
                    .HasForeignKey(d => d.PayableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverPaymentDetail_PayableDetail");
            });

            modelBuilder.Entity<OverPaymentType>(entity =>
            {
                entity.ToTable("OverPaymentType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnType("character varying");
            });

            modelBuilder.Entity<PayGroupWise>(entity =>
            {
                entity.ToTable("PayGroupWise", "pa");

                entity.HasIndex(e => e.BatchId)
                    .HasName("i_paygroupwise_batchid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.PayGroupWise)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWise_Batch");
            });

            modelBuilder.Entity<PayGroupWiseOrganization>(entity =>
            {
                entity.ToTable("PayGroupWiseOrganization", "pa");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.PayGroupWiseId).HasColumnName("PayGroupWiseID");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.PayGroupWiseOrganization)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseOrganiation_Organization");

                entity.HasOne(d => d.PayGroupWise)
                    .WithMany(p => p.PayGroupWiseOrganization)
                    .HasForeignKey(d => d.PayGroupWiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseOrganization_PayGroupWise");
            });

            modelBuilder.Entity<PayGroupWiseQueue>(entity =>
            {
                entity.ToTable("PayGroupWiseQueue", "pa");

                entity.HasIndex(e => e.PayGroupWiseId)
                    .HasName("i_paygroupwisequeue_paygroupwiseid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PayGroupWiseId).HasColumnName("PayGroupWiseID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.PayGroupWise)
                    .WithMany(p => p.PayGroupWiseQueue)
                    .HasForeignKey(d => d.PayGroupWiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseQueue_PayGroupWise");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PayGroupWiseQueue)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseQueue_Status");
            });

            modelBuilder.Entity<PayGroupWiseRank>(entity =>
            {
                entity.ToTable("PayGroupWiseRank", "pa");

                entity.HasIndex(e => e.PayGroupWiseId)
                    .HasName("i_paygroupwiserank_paygroupwiseid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PayGroupWiseId).HasColumnName("PayGroupWiseID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.HasOne(d => d.PayGroupWise)
                    .WithMany(p => p.PayGroupWiseRank)
                    .HasForeignKey(d => d.PayGroupWiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseRank_PayGroupWise");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.PayGroupWiseRank)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayGroupWiseRank_Rank");
            });

            modelBuilder.Entity<Payable>(entity =>
            {
                entity.ToTable("Payable", "pa");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_payable_applicationid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('pa.payable_seq'::regclass)");

                entity.Property(e => e.Amount).HasColumnType("numeric(15,2)");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Due).HasColumnType("numeric(15,2)");

                entity.Property(e => e.DueFiscalYearId).HasColumnName("DueFiscalYearID");

                entity.Property(e => e.FiscalYearId).HasColumnName("FiscalYearID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Payable)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payable_ApplicationID");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Payable)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payable_BatchID");

                entity.HasOne(d => d.DueFiscalYear)
                    .WithMany(p => p.PayableDueFiscalYear)
                    .HasForeignKey(d => d.DueFiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payable_DueFiscalYear");

                entity.HasOne(d => d.FiscalYear)
                    .WithMany(p => p.PayableFiscalYear)
                    .HasForeignKey(d => d.FiscalYearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payable_FiscalYearID");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payable)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payable_PaymentTypeID");
            });

            modelBuilder.Entity<PayableDetails>(entity =>
            {
                entity.HasKey(e => e.PayableId)
                    .HasName("pk_payabledetails");

                entity.ToTable("PayableDetails", "pa");

                entity.HasIndex(e => e.PayableId)
                    .HasName("i_payabledetails_payableid")
                    .IsUnique();

                entity.Property(e => e.PayableId)
                    .HasColumnName("PayableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Payable)
                    .WithOne(p => p.PayableDetails)
                    .HasForeignKey<PayableDetails>(d => d.PayableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayableDetails");
            });

            modelBuilder.Entity<Payablelistid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payablelistid");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<PaymentCategory>(entity =>
            {
                entity.ToTable("PaymentCategory", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Identifier).HasMaxLength(100);

                entity.Property(e => e.IdentifierDari)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentTypeInterval>(entity =>
            {
                entity.ToTable("PaymentTypeInterval", "pa");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime).HasMaxLength(20);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.IdentifierDari)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.StartTime).HasMaxLength(20);

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PaymentTypeInterval)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Interval_OccurrenceType");
            });

            modelBuilder.Entity<PensionCardTypes>(entity =>
            {
                entity.ToTable("PensionCardTypes", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PensionCards>(entity =>
            {
                entity.ToTable("PensionCards", "prf");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_pensioncards_applicationid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.pensioncards_seq'::regclass)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.PensionCards)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PensionCards_ApplicationId_fkey");

                entity.HasOne(d => d.CardType)
                    .WithMany(p => p.PensionCards)
                    .HasForeignKey(d => d.CardTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PensionCards_CardTypeId_fkey");
            });

            modelBuilder.Entity<PensionDisability>(entity =>
            {
                entity.ToTable("PensionDisability", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_pensiondisability_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.pensiondisability_seq'::regclass)");

                entity.Property(e => e.DisabilityLevelId).HasColumnName("DisabilityLevelID");

                entity.Property(e => e.DisabilityPlaceId).HasColumnName("DisabilityPlaceID");

                entity.Property(e => e.DisabilityTypeId).HasColumnName("DisabilityTypeID");

                entity.Property(e => e.Discription).HasMaxLength(1000);

                entity.Property(e => e.FormNumber).HasMaxLength(120);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.DisabilityLevel)
                    .WithMany(p => p.PensionDisabilityDisabilityLevel)
                    .HasForeignKey(d => d.DisabilityLevelId)
                    .HasConstraintName("FK_PensionDisability_RankID");

                entity.HasOne(d => d.DisabilityPlace)
                    .WithMany(p => p.PensionDisabilityDisabilityPlace)
                    .HasForeignKey(d => d.DisabilityPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PensionDisability_IncidentPlaceID");

                entity.HasOne(d => d.DisabilityType)
                    .WithMany(p => p.PensionDisabilityDisabilityType)
                    .HasForeignKey(d => d.DisabilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PensionDisability_IncidentTypeID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.PensionDisability)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Disabilit_ProfileID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PensionDisability)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PensionDisability_Type");
            });

            modelBuilder.Entity<PensionType>(entity =>
            {
                entity.ToTable("PensionType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.pensiontype_seq'::regclass)");

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(132);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(132);
            });

            modelBuilder.Entity<PositionType>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("pk_positiontype");

                entity.ToTable("PositionType", "look");

                entity.Property(e => e.PositionId)
                    .HasColumnName("PositionID")
                    .HasDefaultValueSql("nextval('look.positiontype_seq'::regclass)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DescriptionDari).HasMaxLength(200);

                entity.Property(e => e.DescriptionPashto).HasMaxLength(200);
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.ToTable("Process", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.process_seq'::regclass)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

                entity.Property(e => e.Sorter).HasColumnType("numeric(5,3)");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.Process)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Process_ScreenID");
            });

            modelBuilder.Entity<ProcessConnection>(entity =>
            {
                entity.ToTable("ProcessConnection", "se");

                entity.HasIndex(e => new { e.ProcessId, e.ConnectedTo })
                    .HasName("uq_processid_connectedto")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.processconnection_seq'::regclass)");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.HasOne(d => d.ConnectedToNavigation)
                    .WithMany(p => p.ProcessConnectionConnectedToNavigation)
                    .HasForeignKey(d => d.ConnectedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConnectedTo");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessConnectionProcess)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_ProcessID");
            });

            modelBuilder.Entity<ProcessTracking>(entity =>
            {
                entity.ToTable("ProcessTracking", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.processtracking_seq'::regclass)");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ReferedProcessId).HasColumnName("ReferedProcessID");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ProcessTracking)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessTracking_ModuleID");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessTracking)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessTracking_Process");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ProcessTracking)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessTrackin_Status");
            });

            modelBuilder.Entity<Professional>(entity =>
            {
                entity.ToTable("Professional", "cal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.professional_seq'::regclass)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.EducationDegreeId).HasColumnName("EducationDegreeID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.EducationDegree)
                    .WithMany(p => p.Professional)
                    .HasForeignKey(d => d.EducationDegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Professional_EducationDegree");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.Professional)
                    .HasForeignKey(d => d.RegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Professional_Regulation");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Professional)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Professional_Status");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile", "prf");

                entity.HasIndex(e => e.Code)
                    .HasName("profile_code_ix");

                entity.HasIndex(e => e.HashKey)
                    .HasName("unique_hashkey")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.profile_seq'::regclass)");

                entity.Property(e => e.BiometricId).HasColumnName("BiometricID");

                entity.Property(e => e.BirthLocationId).HasColumnName("BirthLocationID");

                entity.Property(e => e.CensusId).HasColumnName("CensusID");

                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.EducationDegreeId).HasColumnName("EducationDegreeID");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GrandFatherName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.HashKey).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(500);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.HasOne(d => d.Biometric)
                    .WithMany(p => p.ProfileNavigation)
                    .HasForeignKey(d => d.BiometricId)
                    .HasConstraintName("FK_Profile_BiometricHistory");

                entity.HasOne(d => d.BirthLocation)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.BirthLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_BirthLocationID");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_District");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_DocumentTypeID");

                entity.HasOne(d => d.EducationDegree)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.EducationDegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_EducationDegree");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profile_Gender");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Profile_Organization");
            });

            modelBuilder.Entity<ProfileCode>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .HasName("pk__profilec__cadb0b726a271320");

                entity.ToTable("ProfileCode", "look");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("OrganizationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentYear).HasColumnType("date");

                entity.HasOne(d => d.Organization)
                    .WithOne(p => p.ProfileCode)
                    .HasForeignKey<ProfileCode>(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProfileCode_Organization");
            });

            modelBuilder.Entity<ProfileList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("profile_list");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(250);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(250);

                entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            });

            modelBuilder.Entity<Profilelist1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("profilelist");

                entity.Property(e => e.ProfileId).HasColumnName("profile_id");
            });

            modelBuilder.Entity<Profilelistid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("profilelistid");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ProvencialProfile>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("ProvencialProfile_pkey");

                entity.ToTable("ProvencialProfile", "prf");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province", "look");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasDefaultValueSql("nextval('look.province_seq'::regclass)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ProvinceName).HasMaxLength(200);

                entity.Property(e => e.ProvinceNameDari).HasMaxLength(200);

                entity.Property(e => e.ProvinceNamePashto).HasMaxLength(200);
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.ToTable("Rank", "look");

                entity.HasIndex(e => e.NameDari)
                    .HasName("uq__rank__ccca5adc6948485f")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.rank_seq'::regclass)");

                entity.Property(e => e.EmployeeCategory).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(132);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(132);

                entity.Property(e => e.Sorter).HasColumnType("numeric(18,2)");
            });

            modelBuilder.Entity<ReEmployment>(entity =>
            {
                entity.ToTable("ReEmployment", "prf");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_reemployment_applicationid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DecreeNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExpectedPensionDate).HasColumnType("date");

                entity.Property(e => e.MonthlySalary).HasColumnType("numeric(7,2)");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.ReemploymentDate).HasColumnType("date");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ReEmployment)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicationId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ReEmployment)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentId");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ReEmployment)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganizationId");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.ReEmployment)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinceId");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.ReEmployment)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RankID");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.ToTable("Referral", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_referral_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.referral_seq'::regclass)");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.PensionTypeId).HasColumnName("PensionTypeID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.ReferralDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Referral_Department");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Referral_Organization");

                entity.HasOne(d => d.PensionType)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.PensionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PensionType");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rererral_Profile");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.Referral)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Referral_Rank");
            });

            modelBuilder.Entity<Regulation>(entity =>
            {
                entity.ToTable("Regulation", "cal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.regulation_seq'::regclass)");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EmployeeTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Regulation)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regulation_EmployeeType");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_RgulationParent_Regulation");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.Regulation)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regulation_ServiceType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Regulation)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regulation_Status");
            });

            modelBuilder.Entity<RegulationRank>(entity =>
            {
                entity.ToTable("RegulationRank", "cal");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.regulationrank_seq'::regclass)");

                entity.Property(e => e.EducationDegreeId).HasColumnName("EducationDegreeID");

                entity.Property(e => e.Factor).HasColumnType("numeric(18,2)");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.Property(e => e.Salary).HasColumnType("numeric(18,0)");

                entity.Property(e => e.SalaryCycleId).HasColumnName("SalaryCycleID");

                entity.Property(e => e.SalaryTypeId).HasColumnName("SalaryTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TermOfService).HasColumnType("numeric(3,1)");

                entity.HasOne(d => d.EducationDegree)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.EducationDegreeId)
                    .HasConstraintName("FK_RegulationRank_EducationDegree");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_RegulationRank_Organization");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulationRank_Rank");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.RegulationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulationRank_Regulation");

                entity.HasOne(d => d.SalaryCycle)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.SalaryCycleId)
                    .HasConstraintName("fk_regulationrank_salarycycle");

                entity.HasOne(d => d.SalaryType)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.SalaryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulationRank_SalaryType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RegulationRank)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegulationRank_Status");
            });

            modelBuilder.Entity<Relative>(entity =>
            {
                entity.ToTable("Relative", "look");

                entity.Property(e => e.RelativeId)
                    .HasColumnName("RelativeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(100);

                entity.Property(e => e.Identifier).HasMaxLength(100);
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.ToTable("Result", "cal");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("i_result_applicationid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('cal.result_seq'::regclass)");

                entity.Property(e => e.AddOnId).HasColumnName("AddOnID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CadreId).HasColumnName("CadreID");

                entity.Property(e => e.CalculatedPercentage).HasColumnType("numeric(5,2)");

                entity.Property(e => e.CalculationTypeId).HasColumnName("CalculationTypeID");

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentTypeID");

                entity.Property(e => e.ProfessionalId).HasColumnName("ProfessionalID");

                entity.Property(e => e.RegulationRankId).HasColumnName("RegulationRankID");

                entity.Property(e => e.TotalPaymentMonth).HasColumnType("numeric(5,2)");

                entity.Property(e => e.TotalService)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.AddOn)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.AddOnId)
                    .HasConstraintName("FK_Result_AddOn");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_Application");

                entity.HasOne(d => d.Cadre)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.CadreId)
                    .HasConstraintName("FK_Result_Cadre");

                entity.HasOne(d => d.CalculationType)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.CalculationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_CalculationType");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_PaymentType");

                entity.HasOne(d => d.Professional)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.ProfessionalId)
                    .HasConstraintName("FK_Result_Professional");

                entity.HasOne(d => d.RegulationRank)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.RegulationRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_RegulationRank");
            });

            modelBuilder.Entity<RetirementRegulation>(entity =>
            {
                entity.ToTable("RetirementRegulation", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.retirementregulation_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.ToTable("Right", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SalaryCycle>(entity =>
            {
                entity.ToTable("SalaryCycle", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<SalaryType>(entity =>
            {
                entity.ToTable("SalaryType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Screen>(entity =>
            {
                entity.ToTable("Screen", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.screen_seq'::regclass)");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DirectoryPath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Screen)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Screen_ModuleID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Screen_ParentID");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.section_seq'::regclass)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NamePashto).HasMaxLength(100);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");
            });

            modelBuilder.Entity<ServiceCadre>(entity =>
            {
                entity.HasKey(e => e.ServiceRecordId)
                    .HasName("pk__servicec__7c38944e8c633a53");

                entity.ToTable("ServiceCadre", "prf");

                entity.HasIndex(e => e.ServiceRecordId)
                    .HasName("i_servicecadre_servicerecordid");

                entity.Property(e => e.ServiceRecordId)
                    .HasColumnName("ServiceRecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.EducationRankId).HasColumnName("EducationRankID");

                entity.HasOne(d => d.EducationRank)
                    .WithMany(p => p.ServiceCadre)
                    .HasForeignKey(d => d.EducationRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCadre_EducationRankID");

                entity.HasOne(d => d.ServiceRecord)
                    .WithOne(p => p.ServiceCadre)
                    .HasForeignKey<ServiceCadre>(d => d.ServiceRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCadre_ServiceRecord");
            });

            modelBuilder.Entity<ServiceDetail>(entity =>
            {
                entity.ToTable("ServiceDetail", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_servicedetail_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.servicedetail_seq'::regclass)");

                entity.Property(e => e.EqualityDate).HasColumnType("date");

                entity.Property(e => e.LastDayOfReceivingSalary).HasColumnType("date");

                entity.Property(e => e.LastJobLeavingDate).HasColumnType("date");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RegulationId).HasColumnName("RegulationID");

                entity.Property(e => e.RegulationInRuledDate).HasColumnType("date");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ServiceDetail)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceDetail_Profile");

                entity.HasOne(d => d.Regulation)
                    .WithMany(p => p.ServiceDetail)
                    .HasForeignKey(d => d.RegulationId)
                    .HasConstraintName("FK_ServiceDetail_Regulation");
            });

            modelBuilder.Entity<ServiceProfessional>(entity =>
            {
                entity.HasKey(e => e.ServiceRecordId)
                    .HasName("pk__servicep__7c38944ecd821579");

                entity.ToTable("ServiceProfessional", "prf");

                entity.HasIndex(e => e.ServiceRecordId)
                    .HasName("i_serviceprofessional_servicerecordid");

                entity.Property(e => e.ServiceRecordId)
                    .HasColumnName("ServiceRecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(18,0)");

                entity.Property(e => e.EducationDegreeId).HasColumnName("EducationDegreeID");

                entity.HasOne(d => d.EducationDegree)
                    .WithMany(p => p.ServiceProfessional)
                    .HasForeignKey(d => d.EducationDegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceProfeesional_EducationDegree");

                entity.HasOne(d => d.ServiceRecord)
                    .WithOne(p => p.ServiceProfessional)
                    .HasForeignKey<ServiceProfessional>(d => d.ServiceRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceProfessional_ServiceRecord");
            });

            modelBuilder.Entity<ServiceRecord>(entity =>
            {
                entity.ToTable("ServiceRecord", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_servicerecord_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.servicerecord_seq'::regclass)");

                entity.Property(e => e.ActualMonthlySalary).HasColumnType("numeric(18,0)");

                entity.Property(e => e.FirstDayOfEmployment).HasColumnType("date");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.LastDayOfEmployment).HasColumnType("date");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.PositionTypeId).HasColumnName("PositionTypeID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RankId).HasColumnName("RankID");

                entity.Property(e => e.SalaryTypeId).HasColumnName("SalaryTypeID");

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");

                entity.Property(e => e.WorkTypeId).HasColumnName("WorkTypeID");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ServiceRecord)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerRec_Organizaton");

                entity.HasOne(d => d.PositionType)
                    .WithMany(p => p.ServiceRecordPositionType)
                    .HasForeignKey(d => d.PositionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecord_MainRank");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ServiceRecord)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PensionServiceRecord_Profile");

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.ServiceRecordRank)
                    .HasForeignKey(d => d.RankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerRec_Rank");

                entity.HasOne(d => d.SalaryType)
                    .WithMany(p => p.ServiceRecord)
                    .HasForeignKey(d => d.SalaryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecord_SalaryTypeID");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.ServiceRecord)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SerRec_ServiceType");

                entity.HasOne(d => d.WorkType)
                    .WithMany(p => p.ServiceRecord)
                    .HasForeignKey(d => d.WorkTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRecord_WorkType");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.ToTable("ServiceType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('look.servicetype_seq'::regclass)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "look");

                entity.HasIndex(e => new { e.Identifier, e.SchemaName, e.DbObject })
                    .HasName("uq_identifier_schema_dbobject")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(32);

                entity.Property(e => e.DbObject)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EnglishIdentifier).HasMaxLength(100);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Status1>(entity =>
            {
                entity.ToTable("Status", "se");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('se.status_seq'::regclass)");

                entity.Property(e => e.Category).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameDari)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.NamePashto).HasMaxLength(60);
            });

            modelBuilder.Entity<Survivor>(entity =>
            {
                entity.ToTable("Survivor", "prf");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("i_survivor_profileid");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("nextval('prf.survivor_seq'::regclass)");

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.FatherName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GrandFatherName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(120);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.Nid)
                    .IsRequired()
                    .HasColumnName("NID")
                    .HasMaxLength(200);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.RelativeId).HasColumnName("RelativeID");

                entity.Property(e => e.SurvivorStatusId).HasColumnName("SurvivorStatusID");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Survivor)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSurvivor_DocumentTypeID");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Survivor)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSurvivor_MaritalStatus");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Survivor)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survivor_Profile");

                entity.HasOne(d => d.Relative)
                    .WithMany(p => p.Survivor)
                    .HasForeignKey(d => d.RelativeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppSurvivor_RelativeID");

                entity.HasOne(d => d.SurvivorStatus)
                    .WithMany(p => p.Survivor)
                    .HasForeignKey(d => d.SurvivorStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survivor_SurvivorStatus");
            });

            modelBuilder.Entity<SurvivorStatus>(entity =>
            {
                entity.ToTable("SurvivorStatus", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tableinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tableinfo");

                entity.Property(e => e.Col).HasColumnName("col");

                entity.Property(e => e.Row).HasColumnName("row");

                entity.Property(e => e.Tablename)
                    .HasColumnName("tablename")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TokenValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PhotoPath).HasMaxLength(500);

                entity.Property(e => e.RelativeId).HasColumnName("RelativeID");

                entity.Property(e => e.RelativeName).HasMaxLength(100);

                entity.Property(e => e.RelativePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.UserAddress).HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Relative)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.RelativeId)
                    .HasConstraintName("fk_relativeid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_userid");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkType>(entity =>
            {
                entity.ToTable("WorkType", "look");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.HasSequence("audittrial_seq", "au").StartsAt(50276);

            modelBuilder.HasSequence("addon_seq", "cal");

            modelBuilder.HasSequence("cadre_seq", "cal");

            modelBuilder.HasSequence("professional_seq", "cal");

            modelBuilder.HasSequence("regulation_seq", "cal").StartsAt(3);

            modelBuilder.HasSequence("regulationrank_seq", "cal").StartsAt(3);

            modelBuilder.HasSequence("result_seq", "cal").StartsAt(33);

            modelBuilder.HasSequence("department_seq", "look").StartsAt(239);

            modelBuilder.HasSequence("district_seq", "look").StartsAt(435);

            modelBuilder.HasSequence("educationdegree_seq", "look").StartsAt(17);

            modelBuilder.HasSequence("organization_seq", "look").StartsAt(215);

            modelBuilder.HasSequence("pensiontype_seq", "look").StartsAt(18);

            modelBuilder.HasSequence("positiontype_seq", "look").StartsAt(271);

            modelBuilder.HasSequence("province_seq", "look").StartsAt(36);

            modelBuilder.HasSequence("rank_seq", "look").StartsAt(419);

            modelBuilder.HasSequence("retirementregulation_seq", "look").StartsAt(5);

            modelBuilder.HasSequence("section_seq", "look").StartsAt(30);

            modelBuilder.HasSequence("servicetype_seq", "look").StartsAt(6);

            modelBuilder.HasSequence("batch_seq", "pa").StartsAt(39);

            modelBuilder.HasSequence("due_seq", "pa");

            modelBuilder.HasSequence("dueaddonlog_seq", "pa");

            modelBuilder.HasSequence("fiscalyear_seq", "pa").StartsAt(94);

            modelBuilder.HasSequence("organizationorder_seq", "pa");

            modelBuilder.HasSequence("payable_seq", "pa").StartsAt(76);

            modelBuilder.HasSequence("accountbatch_seq", "prf");

            modelBuilder.HasSequence("address_seq", "prf").StartsAt(4);

            modelBuilder.HasSequence("application_seq", "prf").StartsAt(1039);

            modelBuilder.HasSequence("bankaccount_seq", "prf");

            modelBuilder.HasSequence("heir_seq", "prf");

            modelBuilder.HasSequence("pensioncards_seq", "prf");

            modelBuilder.HasSequence("pensiondisability_seq", "prf");

            modelBuilder.HasSequence("profile_seq", "prf").StartsAt(5013);

            modelBuilder.HasSequence("referral_seq", "prf").StartsAt(20040);

            modelBuilder.HasSequence("servicedetail_seq", "prf").StartsAt(4);

            modelBuilder.HasSequence("servicerecord_seq", "prf").StartsAt(12);

            modelBuilder.HasSequence("survivor_seq", "prf").StartsAt(8);

            modelBuilder.HasSequence("aspnetroleclaims_seq");

            modelBuilder.HasSequence("aspnetroles_screens_seq").StartsAt(1010);

            modelBuilder.HasSequence("aspnetroles_seq").StartsAt(2003);

            modelBuilder.HasSequence("aspnetuserclaims_seq");

            modelBuilder.HasSequence("aspnetusers_category_seq").StartsAt(24);

            modelBuilder.HasSequence("aspnetusers_seq").StartsAt(3024);

            modelBuilder.HasSequence("document_seq", "se");

            modelBuilder.HasSequence("module_seq", "se").StartsAt(105);

            modelBuilder.HasSequence("process_seq", "se").StartsAt(1006);

            modelBuilder.HasSequence("processconnection_seq", "se").StartsAt(1013);

            modelBuilder.HasSequence("processtracking_seq", "se").StartsAt(3053);

            modelBuilder.HasSequence("screen_seq", "se").StartsAt(7057);

            modelBuilder.HasSequence("status_seq", "se").StartsAt(103);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
