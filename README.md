# Baltic Marinas Events Management Web Service

Events Management web service build on ASP.NET Core platform. The purpose of this API is to serve Baltic Marinas booking web
application as a module which handles all the tasks related to events published on the application. 

Baltic Marinas application users that have admin rigts are able to publish information about various events that might interest other visitors.
This functionality is handled by the Events Management API which stores the required data in a MySQL database. 

## Database

The API is connected to a database which has one `event` table:

| Column	| Data Type     |         |
| ------------- |:-------------:| -------:|
| EventId       | int AI PK     | NOT NULL|
| Title         | varchar(100)  | NOT NULL|
| Location      | varchar(100)  | NOT NULL|
| Period        | varchar(50)   | NOT NULL|
| Description   | varchar(1200) | NOT NULL|
| Email         | varchar(100)  | NOT NULL|
| UserId        | int FK        |         |


## Technologies used

+ ASP.NET Core
+ C#
+ MySQL relational database management system (DBMS)

## Getting Started

In order to run the project a small amount of prerequisites and additional steps have to be fulfilled.

### Prerequisites

+ Microsoft Visual Studio IDE
+ Database Management System

### Running

+ Clone the project from GitHub repository
+ Open `BalticMarinasEventsWS.sln` file using Visual Studio IDE
+ Start application by clicking `Play` button
