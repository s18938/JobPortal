using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobPortal.Models
{
    public partial class jobportalContext : DbContext
    {
        public jobportalContext()
        {
        }

        public jobportalContext(DbContextOptions<jobportalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidate> Candidate { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ClientDatabase> ClientDatabase { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Industry> Industry { get; set; }
        public virtual DbSet<JobOffer> JobOffer { get; set; }
        public virtual DbSet<JobOfferCandidate> JobOfferCandidate { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<JobTypeJobOffer> JobTypeJobOffer { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Position> Position { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Data Source=127.0.0.1; Initial Catalog=job-portal; user id=root; password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("candidate");

                entity.HasIndex(e => e.CityCityId)
                    .HasName("candidate_city");

                entity.Property(e => e.CandidateId).HasColumnName("candidateID");

                entity.Property(e => e.CityCityId).HasColumnName("city_cityId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(60);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(60);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CityCity)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.CityCityId)
                    .HasConstraintName("candidate_city");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("cityName")
                    .HasMaxLength(60);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ClientDatabase>(entity =>
            {
                entity.ToTable("clientDatabase");

                entity.Property(e => e.ClientDatabaseId).HasColumnName("clientDatabaseID");

                entity.Property(e => e.ClientDatabaseName)
                    .IsRequired()
                    .HasColumnName("clientDatabaseName")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.ToTable("clientType");

                entity.Property(e => e.ClientTypeId).HasColumnName("clientTypeID");

                entity.Property(e => e.ClientTypeName)
                    .IsRequired()
                    .HasColumnName("clientTypeName")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("document");

                entity.HasIndex(e => e.CandidateCandidateId)
                    .HasName("document_candidate");

                entity.Property(e => e.DocumentId).HasColumnName("documentID");

                entity.Property(e => e.CandidateCandidateId).HasColumnName("candidate_candidateID");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CandidateCandidate)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.CandidateCandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("document_candidate");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.ToTable("employer");

                entity.Property(e => e.EmployerId).HasColumnName("employerID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(60);

                entity.Property(e => e.EmployeesNumber).HasColumnName("employeesNumber");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("blob");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(60);

                entity.Property(e => e.Page)
                    .HasColumnName("page")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("experience");

                entity.HasIndex(e => e.CandidateCandidateId)
                    .HasName("experience_candidate");

                entity.HasIndex(e => e.ClientDatabaseClientDatabaseId)
                    .HasName("experience_clientDatabase");

                entity.HasIndex(e => e.ClientTypeClientTypeId)
                    .HasName("experience_clientType");

                entity.HasIndex(e => e.IndustryIndustryId)
                    .HasName("experience_industry");

                entity.HasIndex(e => e.PositionPositionId)
                    .HasName("experience_position");

                entity.Property(e => e.ExperienceId).HasColumnName("experienceID");

                entity.Property(e => e.CandidateCandidateId).HasColumnName("candidate_candidateID");

                entity.Property(e => e.ClientDatabaseClientDatabaseId).HasColumnName("clientDatabase_clientDatabaseID");

                entity.Property(e => e.ClientTypeClientTypeId).HasColumnName("clientType_clientTypeID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("companyName")
                    .HasMaxLength(60);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IndustryIndustryId).HasColumnName("industry_industryID");

                entity.Property(e => e.PositionPositionId).HasColumnName("position_positionID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.CandidateCandidate)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.CandidateCandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("experience_candidate");

                entity.HasOne(d => d.ClientDatabaseClientDatabase)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.ClientDatabaseClientDatabaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("experience_clientDatabase");

                entity.HasOne(d => d.ClientTypeClientType)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.ClientTypeClientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("experience_clientType");

                entity.HasOne(d => d.IndustryIndustry)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.IndustryIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("experience_industry");

                entity.HasOne(d => d.PositionPosition)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.PositionPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("experience_position");
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.ToTable("industry");

                entity.Property(e => e.IndustryId).HasColumnName("industryID");

                entity.Property(e => e.IndustryName)
                    .IsRequired()
                    .HasColumnName("industryName")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<JobOffer>(entity =>
            {
                entity.ToTable("jobOffer");

                entity.HasIndex(e => e.ClientDatabaseClientDatabaseId)
                    .HasName("jobOffer_clientDatabase");

                entity.HasIndex(e => e.ClientTypeClientTypeId)
                    .HasName("jobOffer_clientType");

                entity.HasIndex(e => e.EmployerEmployerId)
                    .HasName("jobOffer_employer");

                entity.HasIndex(e => e.IndustryIndustryId)
                    .HasName("jobOffer_industry");

                entity.HasIndex(e => e.PositionPositionId)
                    .HasName("jobOffer_position");

                entity.Property(e => e.JobOfferId).HasColumnName("jobOfferID");

                entity.Property(e => e.ClientDatabaseClientDatabaseId).HasColumnName("clientDatabase_clientDatabaseID");

                entity.Property(e => e.ClientTypeClientTypeId).HasColumnName("clientType_clientTypeID");

                entity.Property(e => e.CommissonMax).HasColumnName("commissonMax");

                entity.Property(e => e.CommissonMin).HasColumnName("commissonMin");

                entity.Property(e => e.CompanyCar)
                    .HasColumnName("companyCar")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasMaxLength(300);

                entity.Property(e => e.EmployerEmployerId).HasColumnName("employer_employerID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("date");

                entity.Property(e => e.IndustryIndustryId).HasColumnName("industry_industryID");

                entity.Property(e => e.PositionPositionId).HasColumnName("position_positionID");

                entity.Property(e => e.RecruitmentLink)
                    .HasColumnName("recruitmentLink")
                    .HasMaxLength(60);

                entity.Property(e => e.SalaryMax).HasColumnName("salaryMax");

                entity.Property(e => e.SalaryMin).HasColumnName("salaryMin");

                entity.Property(e => e.SalesCycleLength)
                    .HasColumnName("salesCycleLength")
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(60);

                entity.HasOne(d => d.ClientDatabaseClientDatabase)
                    .WithMany(p => p.JobOffer)
                    .HasForeignKey(d => d.ClientDatabaseClientDatabaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOffer_clientDatabase");

                entity.HasOne(d => d.ClientTypeClientType)
                    .WithMany(p => p.JobOffer)
                    .HasForeignKey(d => d.ClientTypeClientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOffer_clientType");

                entity.HasOne(d => d.EmployerEmployer)
                    .WithMany(p => p.JobOffer)
                    .HasForeignKey(d => d.EmployerEmployerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOffer_employer");

                entity.HasOne(d => d.IndustryIndustry)
                    .WithMany(p => p.JobOffer)
                    .HasForeignKey(d => d.IndustryIndustryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOffer_industry");

                entity.HasOne(d => d.PositionPosition)
                    .WithMany(p => p.JobOffer)
                    .HasForeignKey(d => d.PositionPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOffer_position");
            });

            modelBuilder.Entity<JobOfferCandidate>(entity =>
            {
                entity.ToTable("jobOfferCandidate");

                entity.HasIndex(e => e.CandidateCandidateId)
                    .HasName("jobOfferCandidate_candidate");

                entity.HasIndex(e => e.JobOfferJobOfferId)
                    .HasName("jobOfferCandidate_jobOffer");

                entity.Property(e => e.JobOfferCandidateId).HasColumnName("jobOfferCandidateID");

                entity.Property(e => e.AddDate).HasColumnType("date");

                entity.Property(e => e.CandidateCandidateId).HasColumnName("candidate_candidateID");

                entity.Property(e => e.JobOfferJobOfferId).HasColumnName("jobOffer_jobOfferID");

                entity.HasOne(d => d.CandidateCandidate)
                    .WithMany(p => p.JobOfferCandidate)
                    .HasForeignKey(d => d.CandidateCandidateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOfferCandidate_candidate");

                entity.HasOne(d => d.JobOfferJobOffer)
                    .WithMany(p => p.JobOfferCandidate)
                    .HasForeignKey(d => d.JobOfferJobOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobOfferCandidate_jobOffer");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("jobType");

                entity.Property(e => e.JobTypeId).HasColumnName("jobTypeID");

                entity.Property(e => e.JobTypeName)
                    .IsRequired()
                    .HasColumnName("jobTypeName")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<JobTypeJobOffer>(entity =>
            {
                entity.ToTable("jobTypeJobOffer");

                entity.HasIndex(e => e.JobOfferJobOfferId)
                    .HasName("jobTypeJobOffer_jobOffer");

                entity.HasIndex(e => e.JobTypeJobTypeId)
                    .HasName("jobTypeJobOffer_jobType");

                entity.Property(e => e.JobTypeJobOfferId).HasColumnName("jobTypeJobOfferID");

                entity.Property(e => e.JobOfferJobOfferId).HasColumnName("jobOffer_jobOfferID");

                entity.Property(e => e.JobTypeJobTypeId).HasColumnName("jobType_jobTypeID");

                entity.HasOne(d => d.JobOfferJobOffer)
                    .WithMany(p => p.JobTypeJobOffer)
                    .HasForeignKey(d => d.JobOfferJobOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobTypeJobOffer_jobOffer");

                entity.HasOne(d => d.JobTypeJobType)
                    .WithMany(p => p.JobTypeJobOffer)
                    .HasForeignKey(d => d.JobTypeJobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("jobTypeJobOffer_jobType");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.HasIndex(e => e.CityCityId)
                    .HasName("location_city");

                entity.HasIndex(e => e.JobOfferJobOfferId)
                    .HasName("location_jobOffer");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.CityCityId).HasColumnName("city_cityId");

                entity.Property(e => e.JobOfferJobOfferId).HasColumnName("jobOffer_jobOfferID");

                entity.Property(e => e.Location1)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(60);

                entity.HasOne(d => d.CityCity)
                    .WithMany(p => p.LocationNavigation)
                    .HasForeignKey(d => d.CityCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("location_city");

                entity.HasOne(d => d.JobOfferJobOffer)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.JobOfferJobOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("location_jobOffer");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.PositionId).HasColumnName("positionID");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasColumnName("positionName")
                    .HasMaxLength(60);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
