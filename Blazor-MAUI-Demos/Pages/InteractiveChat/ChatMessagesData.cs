#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
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
using Blazor_MAUI_Demos.Shared;
using Syncfusion.Blazor.InteractiveChat;

namespace Blazor_MAUI_Demos.Pages.InteractiveChatDemo
{
    public class TemplateMessageData
    {
        public string Reply { get; set; }
        public string Text { get; set; }
        public List<string> Suggestions { get; set; }

    }
    public class ListViewData
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string ImgSrc { get; set; }
        public string Message { get; set; }
    }
    public class ChatMessagesData
    {
        public List<ChatMessage> GetApiChatMessages() {
            List<ChatMessage> ApiChatMessages = new List<ChatMessage>
            {
                new ChatMessage()
                {
                    Text = "Hey Michale, Charlie! Seen the latest posts in the Design Community? Amazing projects!",
                    Timestamp = new DateTime(2024,10,25,7,30,0),
                    Author = new UserModel()
                    {
                        ID = "admin",
                        User = "Alice"
                    }
                },
                new ChatMessage()
                {
                    Text = "Hi Alice! Yes, Dana’s new UI design is incredible.",
                    Timestamp = new DateTime(2024,10,25,8,0,0),
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Michale Suyama",
                        AvatarBgColor = "#bacbe4"
                    }
                },
                new ChatMessage()
                {
                    Text = "Hey! I loved Dana’s use of color. Frank’s typography guide was great too.",
                    Timestamp = new DateTime(2024,10,25,11,0,0),
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Charlie",
                        AvatarBgColor = "#e6cdde",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                },
                new ChatMessage()
                {
                    Text = "Absolutely! Any new community events planned?",
                    Timestamp = new DateTime(2024,10,26,11,0,0),
                    Author = new UserModel()
                    {
                        ID = "admin",
                        User = "Alice"
                    }
                },
                new ChatMessage()
                {
                    Text = "We should organize a design challenge.",
                    Timestamp = new DateTime(2024,10,26,12,15,0),
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Michale Suyama",
                        AvatarBgColor = "#bacbe4"
                    }
                },
                new ChatMessage()
                {
                    Text = "I am excited to see the new projects.",
                    Timestamp = new DateTime(2024,10,26,12,17,0),
                    Author = new UserModel()
                    {
                        ID = "user3",
                        User = "Janet",
                        AvatarBgColor = "#dec287",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/janet.png"
                    }
                },
                new ChatMessage()
                {
                    Text = "Great idea! Let’s discuss it in the next meeting.",
                    Timestamp = new DateTime(2024,10,26,12,30,0),
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Charlie",
                        AvatarBgColor = "#e6cdde",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                },
                new ChatMessage()
                {
                    Text = "Sounds good! This community is so inspiring.",
                    Author = new UserModel()
                    {
                        ID = "admin",
                        User = "Alice"
                    }
                },
                new ChatMessage()
                {
                    Text = "Agreed! Excited to see everyone’s ideas.",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Michale Suyama",
                        AvatarBgColor = "#bacbe4"
                    }
                },
                new ChatMessage()
                {
                    Text = "I am looking forward to the design challenge.",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Charlie",
                        AvatarBgColor = "#e6cdde",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                }
            };
            return ApiChatMessages;
        }
        
        public List<ChatMessage> GetUserChatMessages()
        {
            List<ChatMessage> UserChatMessages = new List<ChatMessage>()
            {
                new ChatMessage() { Text = "Hi there! How's it going?", Author = new UserModel()
                    {
                        ID = "User1",
                        User = "Albert",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/andrew.png"
                    }
                },
                new ChatMessage() { Text = "Hey! I'm doing well, thanks. How about you?", Author = new UserModel()
                    {
                        ID = "User2",
                        User = "Reena",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/reena.png"
                    }
                },
                new ChatMessage() { Text = "Mostly the usual stuff. I did start a new hobby - painting!", Author = new UserModel()
                    {
                        ID = "User1",
                        User = "Albert",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/andrew.png"
                    }
                },
            };
            return UserChatMessages;
        }
        public UserModel GetSpecificUser(string Id, string Username, string ImageDir, string BgColor)
        {
            return new UserModel()
            {
                ID = Id,
                User = Username,
                AvatarUrl = ImageDir!= null ? new SampleService().WebAssetsPath + $"images/chat-ui/{ImageDir}.png" : null,
                AvatarBgColor = BgColor
            };
        }
        public List<string> GetChatSuggestions()
        {
            return new List<string> { "Awesome!", "What kind of painting ?" };
        }

        public List<TemplateMessageData> GetTemplateMessages()
        {
            return new List<TemplateMessageData>
            {
                new TemplateMessageData() {
                    Text = "Hello! I'm the Order tracking bot. how can I help you today?",
                    Suggestions = new List<string>() { "Track an order", "Cancel an order" }
                },
                new TemplateMessageData() {
                    Text = "Track an order",
                    Reply = "Please select the order you want to track.",
                    Suggestions = new List<string>() {"Order #67890", "Order #53461"}
                },
                new TemplateMessageData() {
                    Text = "Order #67890",
                    Reply = "Fetching details for order <b>#67890</b> </br></br> Your order is currently being processed and will ship in 2-3 days.",
                    Suggestions = new List<string>() { "Back to main menu", "Need help with something else" }
                },
                new TemplateMessageData() {
                    Text = "Order #53461",
                    Reply = "Fetching details for order <b>#53461</b> </br></br> Your order is currently being processed and will ship in 2-3 days.",
                    Suggestions = new List<string>() {"Back to main menu", "Need help with something else" }
                },
                new TemplateMessageData() {
                    Text = "Order #87890",
                    Reply = "Your order <b>#87890</b> has been cancelled.",
                    Suggestions = new List<string>() { "Back to main menu", "Need help with something else" }
                },
                new TemplateMessageData() {
                    Text = "Order #90910",
                    Reply = "Your order <b>#90910</b> has been cancelled.",
                    Suggestions = new List<string>() {"Back to main menu", "Need help with something else" }
                },
                new TemplateMessageData() {
                    Text = "Cancel an order",
                    Reply = "Pick the order you need to cancel.",
                    Suggestions = new List<string>() {"Order #87890", "Order #90910" }
                },
                new TemplateMessageData() {
                    Text = "Back to main menu",
                    Reply = "You have returned to the main menu. What would you like to do next?",
                    Suggestions = new List<string>() {"Track an order", "Cancel an order" }
                },
                new TemplateMessageData() {
                    Text = "Need help with something else",
                    Reply = "Please hold while we connect you to a support agent. You can chat with them for any additional queries.",
                    Suggestions = new List<string>()
                }
            };
        }

        public List<ListViewData> GetListItems()
        {
            List<ListViewData> ListItems = new List<ListViewData>()
            {
                new ListViewData() { ID="01", Title="Albert", ImgSrc="andrew", Message="Okay, I'll try that. Thanks for the help!"},
                new ListViewData() { ID="02", Title="Bot", ImgSrc="bot", Message="Personal decor assistant"},
                new ListViewData() { ID="03", Title="Charlie", ImgSrc="charlie", Message="Great! Let's finalize our plans this weekend."},
                new ListViewData() { ID="04", Title="Laura Callahan", ImgSrc="Laura", Message="10 AM works for me."},
                new ListViewData() { ID="05", Title="New Dev Team", ImgSrc="calendar", Message="User added"},
                new ListViewData() { ID="06", Title="Reena", ImgSrc="reena", Message="You: Hi, are you available ?"}
            };
            return ListItems;
        }

        public List<List<ChatMessage>> GetChatMessages()
        {
            List<ChatMessage> user1 = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hey, I'm having trouble with my computer. It keeps freezing.",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Reena",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/reena.png"
                    }
                },
                new ChatMessage() {
                    Text = "Oh, that's annoying. Have you tried restarting it?",
                    Author = new UserModel()
                    {
                        ID = "User2",
                        User = "Albert",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/andrew.png"
                    }
                },
                new ChatMessage() {
                    Text = "Yeah, I did, but it didn't help.",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Reena",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/reena.png"
                    }
                },
                new ChatMessage() {
                    Text = "Sometimes, outdated software or malware can cause issues.",
                    Author = new UserModel()
                    {
                        ID = "User2",
                        User = "Albert",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/andrew.png"
                    }
                },
                new ChatMessage() {
                    Text = "Okay, I'll try that. Thanks for the help!",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Reena",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/reena.png"
                    }
                }
            };

            List<ChatMessage> admin = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hello Sam, I am a virtual assitant.",
                    Author = new UserModel()
                    {
                        ID = "bot",
                        User = "Bot",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/bot.png"
                    }
                },
                new ChatMessage() {
                    Text = "Which room are you looking to decorate?",
                    Author = new UserModel()
                    {
                        ID = "bot",
                        User = "Bot",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/bot.png"
                    }
                }
            };

            List<ChatMessage> user2 = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hey Charlie, have you thought about where you want to go for our vacation?",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Sam",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                },
                new ChatMessage() {
                    Text = "Hi Sam! I was thinking about going to Bali. I've heard the beaches are beautiful and there's so much to do.",
                    Author = new UserModel()
                    {
                        ID = "user5",
                        User = "Charlie",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                },
                new ChatMessage() {
                    Text = "Bali sounds amazing! I've always wanted to try surfing. Do you know any good places to stay?",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Sam",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                },
                new ChatMessage() {
                    Text = "Yes, I found a few nice resorts and some budget-friendly options too. I'll send you the links.",
                    Author = new UserModel()
                    {
                        ID = "user5",
                        User = "Charlie",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                },
                new ChatMessage() {
                    Text = "Great! Let's finalize our plans this weekend.",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Sam",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                }
            };

            List<ChatMessage> user3 = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hey Sam, can we have a quick meeting tomorrow morning to discuss the new project?",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Laura Callahan",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                },
                new ChatMessage() {
                    Text = "Sure, what time works best for you?",
                    Author = new UserModel()
                    {
                        ID = "user3",
                        User = "Sam",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                },
                new ChatMessage() {
                    Text = "10 AM?",
                    Author = new UserModel()
                    {
                        ID = "user1",
                        User = "Laura Callahan",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                },
                new ChatMessage() {
                    Text = "10 AM works for me.",
                    Author = new UserModel()
                    {
                        ID = "user3",
                        User = "Sam",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/laura.png"
                    }
                }
            };

            List<ChatMessage> team = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hi, everyone!, welcome to the new web team",
                    Author = new UserModel()
                    {
                        ID = "team",
                        User = "Admin"
                    }
                },
                new ChatMessage() {
                    Text = "Hi Sir, excited about the new team.",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Janet",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/janet.png"
                    }
                },
                new ChatMessage() {
                    Text = "Good morning ! suprised with the new team message.",
                    Author = new UserModel()
                    {
                        ID = "user3",
                        User = "Margaret Peacock",
                    }
                },
                new ChatMessage() {
                    Text = "Hi all, what's the purpose of this new team formation ?",
                    Author = new UserModel()
                    {
                        ID = "user2",
                        User = "Charlie",
                        AvatarUrl = new SampleService().WebAssetsPath + "images/chat-ui/charlie.png"
                    }
                },
                new ChatMessage() {
                    Text = "Charlie, we are planning for a new portal launch hence, grouping all in one place.",
                    Author = new UserModel()
                    {
                        ID = "team",
                        User = "Admin"
                    }
                }
            };

            List<ChatMessage> user4 = new List<ChatMessage>()
            {
                new ChatMessage() {
                    Text = "Hi, are you available ?",
                    Author = new UserModel()
                    {
                        ID = "user4",
                        User = "Reena",
                    }
                }
            };

            List<List<ChatMessage>> chatMessages = new List<List<ChatMessage>>() { user1, admin, user2, user3, team, user4 };

            return chatMessages;
        }

        public List<string> GetBotSuggestions()
        {
            return new List<string> { "Bedroom", "Kitchen" };
        }

        public List<TemplateMessageData> GetBotData()
        {
            return new List<TemplateMessageData>()
            {
                new TemplateMessageData()
                {
                    Text = "Bedroom",
                    Reply = "For a bedroom, we can create a serene and calm atmosphere with neutral colors and comfortable bedding.",
                    Suggestions = new List<string> { "Garden", "Balcony" }
                },
                new TemplateMessageData()
                {
                    Text = "Kitchen",
                    Reply = "For a kitchen, we can go for a modern, sleek look with stainless steel appliances and minimalist cabinetry. </br> <p>Any other home decor suggestions you'd like to explore ?</p>",
                    Suggestions = new List<string> { "Wall art", "Plants" }
                }
            };
        }
    }
}
