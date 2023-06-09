﻿// <auto-generated />
using FilmesApi.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmesApi.Migrations;

[DbContext(typeof(FilmeContexto))]
partial class FilmeContextoModelSnapshot : ModelSnapshot
{
	protected override void BuildModel(ModelBuilder modelBuilder)
	{
#pragma warning disable 612, 618
		modelBuilder
			.HasAnnotation("ProductVersion", "7.0.5")
			.HasAnnotation("Relational:MaxIdentifierLength", 128);

		SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

		modelBuilder.Entity("FilmesApi.Modelos.Filme", b =>
			{
				b.Property<int>("Id")
					.ValueGeneratedOnAdd()
					.HasColumnType("int");

				SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

				b.Property<int>("Duracao")
					.HasColumnType("int");

				b.Property<string>("Genero")
					.IsRequired()
					.HasMaxLength(50)
					.HasColumnType("nvarchar(50)");

				b.Property<string>("Titulo")
					.IsRequired()
					.HasColumnType("nvarchar(max)");

				b.HasKey("Id");

				b.ToTable("Filmes");
			});
#pragma warning restore 612, 618
	}
}
