using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HwaidakAPI.OPModels;

public partial class HwaidakHotelsOpedbContext : DbContext
{
    public HwaidakHotelsOpedbContext()
    {
    }

    public HwaidakHotelsOpedbContext(DbContextOptions<HwaidakHotelsOpedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblRequestsContact> TblRequestsContacts { get; set; }

    public virtual DbSet<TblRequestsFaq> TblRequestsFaqs { get; set; }

    public virtual DbSet<TblRequestsMeeting> TblRequestsMeetings { get; set; }

    public virtual DbSet<TblRequestsNewsletter> TblRequestsNewsletters { get; set; }

    public virtual DbSet<TblRequestsWedding> TblRequestsWeddings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

            string connectionString = configuration.GetConnectionString("OPDBConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("titDevOPEDB2024");

        modelBuilder.Entity<TblRequestsContact>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("tbl_Requests_Contacts", "dbo");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.CustomerEmail).HasMaxLength(250);
            entity.Property(e => e.CustomerMessage).HasColumnType("ntext");
            entity.Property(e => e.CustomerName).HasMaxLength(250);
            entity.Property(e => e.CustomerPhone).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.RequestDate).HasColumnType("smalldatetime");
            entity.Property(e => e.RequestIp)
                .HasMaxLength(250)
                .HasColumnName("RequestIP");
            entity.Property(e => e.RequestIpcountry)
                .HasMaxLength(250)
                .HasColumnName("RequestIPCountry");
        });

        modelBuilder.Entity<TblRequestsFaq>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("tbl_Requests_FAQ", "dbo");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.CustomerEmail).HasMaxLength(250);
            entity.Property(e => e.CustomerMessage).HasColumnType("ntext");
            entity.Property(e => e.CustomerName).HasMaxLength(250);
            entity.Property(e => e.CustomerPhone).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.RequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblRequestsMeeting>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("tbl_Requests_Meeting", "dbo");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.EmailAddress).HasMaxLength(250);
            entity.Property(e => e.EventEndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EventStartDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.JobTitle).HasMaxLength(250);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.Numberofattendees).HasMaxLength(250);
            entity.Property(e => e.Numberofguestroomsrequired).HasMaxLength(250);
            entity.Property(e => e.PreferredSetup).HasMaxLength(250);
            entity.Property(e => e.RequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SpecialRequest).HasColumnType("ntext");
            entity.Property(e => e.TelephoneNumber).HasMaxLength(250);
        });

        modelBuilder.Entity<TblRequestsNewsletter>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("tbl_Requests_Newsletter", "dbo");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.Emailaddress)
                .HasMaxLength(250)
                .HasColumnName("emailaddress");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsArchived).HasDefaultValue(false);
            entity.Property(e => e.Startdatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("startdatetime");
        });

        modelBuilder.Entity<TblRequestsWedding>(entity =>
        {
            entity.HasKey(e => e.WeddingId);

            entity.ToTable("tbl_Requests_Wedding", "dbo");

            entity.Property(e => e.WeddingId).HasColumnName("WeddingID");
            entity.Property(e => e.AlternativeWeddingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.DatesFlexible).HasDefaultValue(false);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.GuestRoomsRequired).HasDefaultValue(false);
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsArchive).HasDefaultValue(false);
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.RequestDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.SpecialRequest).HasMaxLength(250);
            entity.Property(e => e.Telephone).HasMaxLength(250);
            entity.Property(e => e.WeddingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.WeddingPlace).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
