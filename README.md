#SchoolManager

###ASP.NET Core web app for managing students, teachers & lessons

Learning objectives:  
`- working with 1 to many & many to many relationships using the Entity Framework & Fluent API and connecting to MySQL database`  
`- scaffolding Razor Pages & adding code for selecting related data` 

###Entity Framework Fluent API
Fluent API is used to configure domain classes to override conventions. In Entity Framework Core, the ModelBuilder class acts as a Fluent API. It provides more configuration options than data annotation attributes. It configures the following aspects of a model:

 - Model Configuration: Configures an EF model to database mappings. Configures the default Schema, DB functions, additional data annotation attributes and entities to be excluded from mapping.
 - Entity Configuration: Configures entity to table and relationships mapping e.g. PrimaryKey, AlternateKey, Index, table name, one-to-one, one-to-many, many-to-many relationships etc.
 - Property Configuration: Configures property to column mapping e.g. column name, default value, nullability, Foreignkey, data type, concurrency column etc.

The many-to-many relationship in the database is represented by a joining table which includes the foreign keys of both tables.
The steps for configuring many-to-many relationships:

- Define a new joining entity class which includes the foreign key property and the reference navigation property for each entity.
- Define a one-to-many relationship between other two entities and the joining entity, by including a collection navigation property in entities at both sides (Student and Course, in this case).
- Configure both the foreign keys in the joining entity as a composite key using Fluent API.

**A public virtual property**: This lets Entity Framework use its Lazy Loading feature so the associated entities will be fetched as needed.