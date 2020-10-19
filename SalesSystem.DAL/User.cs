﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesSystem.DAL
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            Stocks = new HashSet<Stock>();
            UserDetails = new HashSet<UserDetail>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("password")]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
        [InverseProperty(nameof(Stock.User))]
        public virtual ICollection<Stock> Stocks { get; set; }
        [InverseProperty(nameof(UserDetail.User))]
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}