# Database Systems - Overview #

#### 1. What database models do you know? ####

- ***Hierarchical (tree)*** The hierarchical data model organizes data in a tree structure. There is a hierarchy of parent and child data segments.
- ***Network / graph*** Some data were more naturally modeled with more than one parent per child. So, the network model permitted the modeling of many-to-many relationships in data. The basic data modeling construct in the network model is the set construct. A set consists of an owner record type, a set name, and a member record type. A member record type can have that role in more than one set, hence the multiparent concept is supported. 
- ***Relational (table)*** In such a database the data and relations between them are organised in tables. A table is a collection of records and each record in a table contains the same fields. Certain fields may be designated as keys, which means that searches for specific values of that field will use indexing to speed them up. 
- ***Object-oriented*** This aims to avoid the object-relational impedance mismatch the overhead of converting information between its representation in the database (for example as rows in tables) and its representation in the application program (typically as objects).
 
#### 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
- Manage data stored in tables
- Implement creating / altering / deleting tables and relationships between them (database schema)
- Adding, changing, deleting, searching and retrieving of data stored in the tables
- Support for the SQL language
- Transaction management (optional)
#### 3. Define what is "table" in database terms - 
In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows.
#### 4. Explain the difference between a primary and a foreign key.
***Primary key*** - A table typically has a column or combination of columns that contain values that uniquely identify each row in the table. 

***Foreign key*** - a column or group of columns in a relational database table that provides a link between data in two tables. It acts as a cross-reference between tables because it references the primary key of another table, thereby establishing a link between them.
#### 5. Explain the different kinds of relationships between tables in relational databases.
- ***One-to-many relationships*** - The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between you and a parent. You have only one mother, but your mother may have several children.
- ***Many-to-many relationships*** - Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.
- ***One-to-one relationships*** - Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table.

#### 6. When is a certain database schema normalized? What are the advantages of normalized databases?
Database normalization is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy. Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. 

**Advantages:**

- The database does not have redundant data, it is smaller in size so less money needs to be spent on storage 
- Because there is less data to search through, it is much faster to run a query on the data 
- Because there is no data duplication there is better data integrity and less risk of mistakes. 
- Because there is no data duplication there is less chance of storing two or more different copies of the data 
- Fewer null values and less redundant data, making your database more compact.
- Normalization is conceptually cleaner and easier to maintain and change as your needs change.

#### 7. What are database integrity constraints and when are they used?
Constraints are used to specify rules for the data in a table.
If there is any violation between the constraint and the data action, the action is aborted by the constraint.
There are the following constraints:
- **NOT NULL** Indicates that a column cannot store NULL value
- **UNIQUE** Ensures that each row for a column must have a unique value
- **PRIMARY KEY** A combination of a NOT NULL and UNIQUE. Ensures that a column (or combination of two or more columns) have a unique identity which helps to find a particular record in a table more easily and quickly
- **FOREIGN KEY** Ensure the referential integrity of the data in one table to match values in another table
- **CHECK** Ensures that the value in a column meets a specific condition
- **DEFAULT** Specifies a default value for a column

#### 8. Point out the pros and cons of using indexes in a database.
Indexes speed up SELECT's and slow down INSERT's.

**Pros:**

- Faster lookup for results. Instead of scanning the entire table for the results, you can reduce the number of disk IO's(page fetches) by using index structures such as B-Trees or Hash Indexes to get to your data faster.

**Cons:**

- Slower writes(potentially). Not only do you have to write your data to your tables, but you also have to write to your indexes. This may cause the system to restructure the index structure(Hash Index, B-Tree etc), which can be very computationally expensive.

- Takes up more disk space, naturally. You are storing more data.

#### 9. What's the main purpose of the SQL language?
SQL is Structured Query Language, which is a computer language for storing, manipulating and retrieving data stored in relational database.

#### 10. What are transactions used for? Give an example.

A transaction is a unit of work that you want to treat as "a whole". It has to either happen in full, or not at all.

A classical example is transferring money from one bank account to another. To do that you have to first withdraw the amount from the source account, and then deposit it to the destination account. The operation has to succeed in full. If you stop halfway, the money will be lost, and that is Very Bad.

In modern databases transactions also do some other things - like ensure that you can't access data that another person has written halfway. But the basic idea is the same - transactions are there to ensure, that no matter what happens, the data you work with will be in a sensible state. They guarantee that there will NOT be a situation where money is withdrawn from one account, but not deposited to another.

#### 11. What is a NoSQL database?
Next Generation Databases mostly addressing some of the points: being non-relational, distributed, open-source and horizontally scalable. A NoSQL database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. 

#### 12. Explain the classical non-relational data models.
- **Document databases** pair each key with a complex data structure known as a document. Documents can contain many different key-value pairs, or key-array pairs, or even nested documents.
- **Graph stores** are used to store information about networks, such as social connections. Graph stores include Neo4J and HyperGraphDB.
- **Key-value stores** are the simplest NoSQL databases. Every single item in the database is stored as an attribute name (or "key"), together with its value. Examples of key-value stores are Riak and Voldemort. Some key-value stores, such as Redis, allow each value to have a type, such as "integer", which adds functionality.
- **Wide-column stores** such as Cassandra and HBase are optimized for queries over large datasets, and store columns of data together, instead of rows.

#### 13. Give few examples of NoSQL databases and their pros and cons.

##### - MongoDB
- **Pros:**

    - schema-less. If you have a flexible schema, this is ideal for a document store like MongoDB. 
    - Ease of development
    - cost. Depends on which RDBMS of course, but MongoDB is free and can run on Linux, ideal for running on cheaper commodity kit.
    - you can choose what level of consistency you want depending on the value of the data (e.g. faster performance = fire and forget inserts to MongoDB, slower performance = wait till insert has been replicated to multiple nodes before returning)

- **Cons:**

    - Data size in MongoDB is typically higher due to e.g. each document has field names stored it
    - less flexibity with querying (e.g. no JOINs)
    - no support for transactions certain atomic operations are supported, at a single document level
    - to do aggregations/data analysis is OK, but not fast. 
    - less up to date information available/fast evolving product

##### - Redis
- **Pros:**

    - Redis is a high performance persistence key value In-memory data store, typically used for  applications where performance and flexibility are more critical than persistence and absolute data integrity

- **Cons:**
    - Complex to configure -requires consideration of data size to configure well
    - Lots of server administration for monitoring and partitioning 


##### - Cassandra
- **Pros:**

    - Write performance, durability, linear scalability, no single point of failure

- **Cons:**
    - More complex to use
    - Queries are slow and can kill node