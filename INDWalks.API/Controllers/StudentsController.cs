using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace INDWalks.API.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "Ram", "Shyam", "Madhu", "Paglu" , "Jeet"};

            return Ok(studentNames);
        }
    }
}




/*PAGINATION- An important feature that is used to limit the amount of data returned to the client.
              It allows us to divide large chuncks of data into smaller parts which makes it easier for clients to consume and navigate through data.*/


/* Authentication- process of determining a user's identity
   usually done by using a username and password
   
   Authorization- refers to the process of determining whether a user has permission to perfrom a certain action or access a particular resource.
    It can be based on various factors such as roles, policies, claims, authentication status
     Such as a user can have a read only role or a read write role*/


/*Authentication Flow:-
 Server creates an JWT (JSON Web Tokens) token and passes it to the client
  JWT Tokens- it is a method/ way to securely transmit information between parties as JSON Objects*/

/* Process:- 1. user puts their login and password in a website 'www' and the website send this information to the API
             2. The api will check the username and password and if it is correct, then it will generate a JWT token for the website user
             3. The website will then use this JWT token as a way to make HTTP calls to API to access the resources of the API and get data from the API
             4. Again the API will check if the token is correct and if it is then it will return the data to that the website the user asked for*/
      

/* 
    Setting up Auth Database
 1. Create New connection string
 2. Create New DbContext with Roles(Seed Data)
 3. Inject DbContext and Identity(ASP.NET Core Identity) - Identity is used for managing authentication, authorization, etc.
 4. Run EF Core Migrations
*/

/* Two Roles:- 
 1. Reader- peform GET Operations
 2. Writer- peform POST, PUT, DELETE Operations

*/

/*
 base(options)=> it is used when we inject DbContext in the Program.cs file with our own options
 */