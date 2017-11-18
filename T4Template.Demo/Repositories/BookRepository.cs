 

      
 

using System;
using System.Data;
using System.Linq;
using T4Template.Demo.Models;  


namespace T4Template.Demo
{
    public class BookRepository : IBookRepository
    {
        public BookRepository()
        {
            
        }
		
		public Book GetById(int id)
		{
		
			return new Book();
		}
      
	  public  Book Create(Book model)
	  {
	  
		  return model;
	  
	  }
      public  Book Update(Book model)
	  {
		return model;
	  }
      public int Delete(Book model)
	  {
		return 0;
	  }
      
    }
}
  
