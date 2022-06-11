﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ArticleList
{
    internal class filters
    {
        public static void GetArticleByAuthor(List<Article> articles, string author)
        {
            Console.WriteLine("Articles from " + author+" are: ");
            foreach(Article item in articles)
            {
                if(item.Author==author)
                    Console.WriteLine(item.Title);
            }
        }

        public static void GetArticleByTitle(List<Article> articles, string title)
        {
            Console.WriteLine("The author of "+title+" is: ");
            foreach(Article item in articles)
                if(item.Title==title)
                    Console.WriteLine(item.Author);
        }

        public static void GetArticleBetweenDates(List<Article> articles, DateTime dateTime1, DateTime dateTime2)
        {
            Console.WriteLine("The articles between "+dateTime1+" and "+dateTime2+" are: ");
            foreach(Article item in articles)
                if(item.Publication>=dateTime1 && item.Publication<=dateTime2)
                    Console.WriteLine(item.Title);
        }

        public static void GetArticleFromWeekend(List<Article> articles)
        {
            Console.WriteLine("Titlurile articolelor publicate in weekend sunt: ");
            foreach(Article item in articles)
                if(item.Publication.DayOfWeek==DayOfWeek.Saturday || item.Publication.DayOfWeek == DayOfWeek.Sunday)
                    Console.WriteLine(item.Title);
        }

        public static void GetArticlesChronological(List<Article> articles)
        {
            Console.WriteLine("Titlurile articolelor ordonate coronologic sunt: ");
            var sorted = from article in articles orderby article.Publication select article;
            foreach(var item in sorted)
                Console.WriteLine(item.Title);
        }

        public static void GetArticlesOrderedAscByLikes(List<Article> articles)
        {
            Console.WriteLine("Titlurile articolelor ordonate crescator dupa like-uri sunt: ");
            var sorted = from article in articles orderby article.Likes select article;
            foreach (var item in sorted)
                Console.WriteLine(item.Title);
        }

        public static void GetArticlesOrderedAscByDislikes(List<Article> articles)
        {
            Console.WriteLine("Titlurile articolelor ordonate crescator dupa dislike-uri sunt: ");
            var sorted = from article in articles orderby article.Dislikes select article;
            foreach (var item in sorted)
                Console.WriteLine(item.Title);
        }

        
    }
}