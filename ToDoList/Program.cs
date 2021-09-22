using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("------------To Do List-------------");
      Console.WriteLine("Would you like to add an item to your list or view your list?");
      Console.WriteLine("type add to add to list, type view to view your list");
      string response = Console.ReadLine();
      if(response == "add" || response == "Add")
      {
        Console.WriteLine("Please Input your new list item");
        string listItem = Console.ReadLine();
        Item newItem = new Item(listItem);
        Console.WriteLine($"{listItem} has been added to your To Do list");
        Main();
      }
      else if (response == "view" || response == "View")
      {
          List <Item> outputList = Item.GetAll();
          int i = 0;
          foreach (var item in outputList)
          {
            ++i;
            Console.WriteLine($"{i}: {item.Description}");
          }
          
          Main();
        }
      else
      {
        Console.WriteLine("Please input a valid response, or would you like to exit? Y for try again or [enter] for exit");
        string userInput = Console.ReadLine();
        if (userInput == "y" || userInput == "Y")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Goodbye!");
        }
      }
      }
    }
}