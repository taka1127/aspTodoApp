using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    public class TodoesContext : DbContext
    {
        // DBから取得したTodoを格納するDbSetを用意。このプロパティを通じてデータの取得や更新を行う。
        public DbSet<Todo> Todoes { get; set; }
    }
}