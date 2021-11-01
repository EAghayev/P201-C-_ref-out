using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class LibraryStore
    {
        public LibraryStore()
        {
            this.Books = new Book[0];
        }
        public Book[] Books;

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            int count = 0;
            foreach (var item in this.Books)
            {
                if (item.Genre.ToLower() == genre.ToLower()) count++;
            }

            Book[] filtedBooks = new Book[count];

            int index = 0;
            foreach (var item in this.Books)
            {
                if (item.Genre.ToLower() == genre.ToLower())
                {
                    filtedBooks[index] = item;
                    index++;
                }
            }

            return filtedBooks;
        }


        public Book[] GetFilteredBooks(double minPrice,double maxPrice)
        {
            int count = 0;
            foreach (var item in this.Books)
            {
                if (item.Price>=minPrice && item.Price<=maxPrice) count++;
            }

            Book[] filteredBooks = new Book[count];

            int index = 0;
            foreach (var item in this.Books)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    filteredBooks[index] = item;
                    index++;
                }
            }

            return filteredBooks;
        }

        public bool IsExistByNo(int no)
        {
            foreach (var item in this.Books)
            {
                if (item.No == no) return true;
            }

            return false;
        }

    }
}
