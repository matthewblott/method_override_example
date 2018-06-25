using System;
using Microsoft.AspNetCore.Mvc;

namespace method_override_example
{
  public class PersonController : Controller
  {
    public string Post(Person person) => GetMessage(person);

    public string Put(Person person) => GetMessage(person);

    public string Patch(Person person) => GetMessage(person);

    public string Delete(Person person) => GetMessage(person);

    string GetMessage(Person person) =>
      $"{this.Request.Method} request received for {person.FirstName} {person.LastName}";

  }

}