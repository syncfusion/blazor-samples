#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Notifications
    {
    public class ContactList
        {
        public ContactList()
            {

            }
        public ContactList(string Id, string Text, string Contact, string Avatar, string Pic)
            {
            this.Id = Id;
            this.Text = Text;
            this.Contact = Contact;
            this.Avatar = Avatar;
            this.Pic = Pic;
            }
        public static List<ContactList> GetAllRecords()
            {
            List<ContactList> contacts = new List<ContactList>();
            for (int i = 1; i < 2; i++)
                {
                contacts.Add(new ContactList("1", "Jenifer", "(206) 555-985774", "", "pic01"));
                contacts.Add(new ContactList("2", "Amenda", "(206) 555-3412", "A", ""));
                contacts.Add(new ContactList("4", "Isabella", "(206) 555-8122", "", "pic02"));
                contacts.Add(new ContactList("5", "William", "(206) 555-9482", "W", ""));
                contacts.Add(new ContactList("6", "Jacob", "(71) 555-4848", "", "pic04"));
                contacts.Add(new ContactList("7", "Matthew", "(71) 555-7773", "M", ""));
                contacts.Add(new ContactList("8", "Oliver", "(71) 555-5598", "", "pic03"));
                contacts.Add(new ContactList("9", "Charlotte", "(206) 555-1189", "C", ""));
                }
            return contacts;
            }
        public string Id { get; set; }
        public string Text { get; set; }
        public string Contact { get; set; }
        public string Avatar { get; set; }
        public string Pic { get; set; }
        }
    }

