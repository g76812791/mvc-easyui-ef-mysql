﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Entity
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class kbase_adminEntities : DbContext
{
    
    public kbase_adminEntities()
        : base("name=kbase_adminEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<anlidetails> anlidetails { get; set; }

    public DbSet<anlitype> anlitype { get; set; }

    public DbSet<downfile> downfile { get; set; }

    public DbSet<loginlog> loginlog { get; set; }

    public DbSet<user> user { get; set; }

    public DbSet<view_loginlog> view_loginlog { get; set; }

    public DbSet<view_anlidetails> view_anlidetails { get; set; }

    public DbSet<image> image { get; set; }

    public DbSet<homeinfo> homeinfo { get; set; }

    public DbSet<daohang> daohang { get; set; }

    public DbSet<fankui> fankui { get; set; }

    public DbSet<menue> menue { get; set; }

    public DbSet<permission> permission { get; set; }

    public DbSet<role> role { get; set; }

    public DbSet<userrole> userrole { get; set; }

    public DbSet<view_user> view_user { get; set; }

    public DbSet<rolemenue> rolemenue { get; set; }

    public DbSet<view_userrole> view_userrole { get; set; }

    public DbSet<view_rolemenue> view_rolemenue { get; set; }

    public DbSet<rolepermission> rolepermission { get; set; }

}

}

