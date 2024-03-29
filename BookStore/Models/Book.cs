﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
  [Table("Book")]
  public class Book
  {
    [Key]
    public int Id { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public string CoverImage { get; set; }
    public DateTime ReleaseDate { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int TotalNumberOfPages { get; set; }


    [Required]
    [ForeignKey("Author")]
    public int  AuthorId { get; set; }

    public virtual Author Author { get; set;}
    public virtual ICollection<BookByOrder> BookByOrder { get; set; }
  }
}
