# Lab 12: Async Inn Management System

## The Problem Domain

Now that you have a solid understanding of your database schema for your hotel management system, today you will build off of your initial web application from lab 11 and integrate into it our database tables from our ERD.

This lab will be a "tutorial" style, meaning it is encouraged that you follow along with the steps and notice how the data evolves as you move through the instructions. A few things for you to notice:

1. The creation of the migration scripts and how they are applied to the database
1. The simple models and how they define the shape of each database table
1. The creation of the controllers and how they control the routing of the api

Don't forget to use the class demo code as an example of how to structure specific code or syntax.

Let's begin...

## Reference Material

[Demo Build Checklist](../resources/ef-web-app.md)

Async Inn ERD:

![Async Inn ERD](./async-inn-erd.png)

## Application Specifications

### Startup File

1. Create a new Empty .NET Core Web Application to and implement the basic setup to create your API server:

- Add explicit routing of Controllers in your 'Configure' method
- Enable the use of MVC controllers in your `ConfigureServices` method
- DBContext registered in `ConfigureServices`

### Simple Models & The Database

1. Create a new Models folder that will contain your basic entities from your ERD

- Create a `Hotel` model that contains the same propertied defined in your ERD
- Don't worry about adding the Navigation properties just yet. We will add those in later.

1. After your first simple model is created, Create a new `Data` folder and add a new `AsyncInnDbContext` file. Make your new class derive from the `DbContext` class, as well as creating the constructor with the proper parameters. Use the demo code as an example.

1. Register your DbContext in your startup file. Configure your `appsettings.json` file to include your connection string.

1. Go back to your `AsyncInnDbContext` file, and add a new property to include a new table into your database. `public DbSet<Hotel> Hotels {get; set;}`. Be sure to include the Models namespace into our current cs file.

1. Now that you have your database registered, and a single table property inside of your dbContext file, create a new migration to see the script that creates and adds that table to the database:
    - Terminal: `dotnet ef migrations add AddHotelsTable`
    - Package Manager Console: `Add-Migration AddHotelsTable`

1. Once you create the migration, apply it to your database:
    - Terminal: `dotnet ef database update`
    - Package Manager Console `Update-Database`

1. Confirm in your local database that the `Hotels` table has been added.

1. You just successfully created and added your first table to your local DB! Now, let's add the other two tables, except this time, we can just add the tables at the same time and have the script include both of them when adding to the database

1. Go back to your `Models` folder and add two new class files; `Room` and `Amenity`.

1. Populate each of these classes with the same properties that you have defined inside of your ERD. Don't worry about adding the Navigation properties yet. We will add those later.

1. Go back into your `AsyncInnDbContext` file and add the two additional properties to represent the Room and the Amenity models.
    - `public DbSet<Room> Rooms {get; set;}`
    - `public DbSet<Amenity> Amenities {get; set;}`

1. Create a new migration to include the creation of these two new tables:
    - Terminal: `dotnet ef migrations add AddRoomsAndAmenitiesTables`
    - Package Manager Console `Add-Migration AddRoomsAndAmenitiesTables`

1. Finally, apply migrations and watch those two new tables get added to the database. Confirm locally that the tables exist.
    - Terminal: `dotnet ef database update`
    - Package Manager Console `Update-Database`

### Seeding data

Let's add some default data into our tables on it's initial launch.

1. Within your `AsyncInnDbContext` add a new override method for the `OnModelCreating` method under your constructor.
1. Seed in some default data for all three of your simple models

- 3 hotels
- 3 rooms
- 3 amenities

Here is an example of adding a single default item to a table: (source [HERE](https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding){:target="_blank"}

```csharp
modelBuilder.Entity<Blog>().HasData(new Blog {BlogId = 1, Url = "http://sample.com"});
```

After creating the seeded data, you will now want to create a new migration so that the seeded data can get added to the database tables

1. Create a new migration:
    - Terminal: `dotnet ef migrations add AddSeedData`
    - Package Manager Console `Add-Migration AddSeedData`

1. Notice how the migration scripts created include the default data for all 3 tables.

1. Apply migrations so that the data gets added to the table
    - Terminal: `dotnet ef database update`
    - Package Manager Console `Update-Database`

1. Confirm that the data was added to your local database for all 3 tables.

### Controllers

Now that we have completed our "Code First Migrations" in the directions above. Let's add some routes so that we can access the data through an API.

1. Create a new folder named `Controllers` in your project.
1. Right click on the folder, and choose Add >> Controller
1. Choose the Entity Framework Scaffold for API option
1. Select the `Hotel` Entity for your model
1. Select your `AsyncInnDbContext` as your DbContext
1. After it's been scaffolded, confirm through [Postman](https://www.postman.com/download) that your can do basic CRUD operations on the Hotels route

Follow the instructions above to scaffold out the `Room` and `Amenity` Controllers.

Once you have all 3 controllers created, and have manually tested the CRUD operations within Postman, your lab is completed. We will continue to build off of this lab over the next few days.

#### README

Your README should be in introduction to your web app. Provide in your README, your ERD Diagram and an overview of the relationships and how each entity is related to another.

## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new repository on your personal GitHub account
- Name your repo `Async-Inn`
- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
