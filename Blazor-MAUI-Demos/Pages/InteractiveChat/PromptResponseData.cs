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

namespace Blazor_MAUI_Demos.Pages.InteractiveChatDemo
{
    public class PromptResponseData
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public List<string> SuggestionData { get; set; }

        public List<string> GetAllSuggestionData()
        {
            return new List<string> { "How do I set daily goals in my work day?", "Steps to publish a e-book with marketing strategy" };
        }

        public List<PromptResponseData> GetAllPromptResponseData()
        {
            List<PromptResponseData> promptResponseData = new List<PromptResponseData>();

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "How do I set daily goals in my work day?",
                Response = "<p>To stay focused and productive, try these steps for setting daily goals:</p> <ol><li><strong>Identify Priorities:</strong> List the most important tasks based on deadlines or significance.</li> <li><strong>Break Down Tasks:</strong> Split larger tasks into smaller, manageable steps.</li> <li><strong>Set SMART Goals:</strong> Make sure goals are Specific, Measurable, Achievable, Relevant, and Time-bound.</li> <li><strong>Time Blocking:</strong> Allocate specific times for each task to stay organized and on track.</li></ol> <p>Would you like more tips on any of these steps?</p>",
                SuggestionData = new List<string> { "How do I prioritize tasks effectively?", "What tools or apps can help me prioritize tasks?" }
            });

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "Steps to publish a e-book with marketing strategy",
                Response = "<p>To publish an e-book, follow the steps below:</p> <ol><li><strong>Write and format your e-book:</strong> Ensure your content is well-organized, edited, and formatted for digital reading.</li> <li><strong>Choose a publishing platform:</strong> Platforms like Amazon Kindle Direct Publishing (KDP) or Smashwords can help you publish and distribute your e-book.</li> <li><strong>Develop a marketing strategy:</strong> Utilize social media, email newsletters, and book promotion sites to create buzz and reach your target audience.</li> <li><strong>Launch and promote:</strong> Schedule a launch date, gather reviews, and continue promoting through various channels to maintain momentum and drive sales.</li></ol> <p>Do you have a specific topic in mind for your e-book?</p>",
                SuggestionData = new List<string> { "How do I create an eye-catching e-book cover?", "What are common mistakes to avoid in e-book covers?" }
            });

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "How do I prioritize tasks effectively?",
                Response = "<p>To stay focused and productive, set daily goals by:</p> <ol><li><strong>Identifying Priorities:</strong> List important tasks based on deadlines or significance.</li> <li><strong>Breaking Down Tasks:</strong> Divide larger tasks into smaller, manageable steps.</li> <li><strong>Setting SMART Goals:</strong> Ensure goals are Specific, Measurable, Achievable, Relevant, and Time-bound.</li> <li><strong>Time Blocking:</strong>Schedule specific times for each task to stay organized.</li></ol> <p>Need more tips on any of these steps?</p>",
                SuggestionData = new List<string>()
            });

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "What tools or apps can help me prioritize tasks?",
                Response = "<p>Here are some tools to help you prioritize tasks effectively:</p> <ol><li><strong>Google Keep:</strong> For simple note-taking and task organization with labels and reminders.</li> <li><strong>Scoro:</strong> A project management tool for streamlining activities and team collaboration.</li> <li><strong>Evernote:</strong> Great for note-taking, to-do lists, and reminders.</li> <li><strong>Todoist:</strong> A powerful task manager for setting priorities and tracking progress.</li></ol> <p>Are you looking for tools to manage a specific type of task or project?</p>",
                SuggestionData = new List<string>()
            });

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "How do I create an eye-catching e-book cover?",
                Response = "<p>Creating an eye-catching e-book cover involves a few key steps:</p> <ol><li><strong>Understand your genre and audience:</strong> Research covers of popular books in your genre to see what appeals to your target readers.</li> <li><strong>Choose the right imagery and colors:</strong> Use high-quality images and a color scheme that reflects the tone and theme of your book.</li> <li><strong>Focus on typography:</strong> Select fonts that are readable and complement the overall design. The title should be prominent and easy to read even in thumbnail size.</li> <li><strong>Use design tools or hire a professional:</strong> Tools like Canva or Adobe Spark can help you create a professional-looking cover. Alternatively, consider hiring a graphic designer for a more polished result.</li></ol> <p>Would you like some tips on where to find good images or fonts for your cover?</p>",
                SuggestionData = new List<string>()
            });

            promptResponseData.Add(new PromptResponseData
            {
                Prompt = "What are common mistakes to avoid in e-book covers?",
                Response = "<p>Here are some common mistakes to avoid when designing an e-book cover:</p> <ol><li><strong>Cluttered design:</strong> Overloading the cover with too many elements can make it look messy and unprofessional. Keep it simple and focused.</li> <li><strong>Poor quality images:</strong> Using low-resolution or generic stock images can detract from the overall appeal. Always opt for high-quality, relevant visuals.</li> <li><strong>Unreadable fonts:</strong> Fancy or overly intricate fonts can be hard to read, especially in thumbnail size. Choose clear, legible fonts for the title and author name.</li> <li><strong>Ignoring genre conventions:</strong> Each genre has its own visual cues. Not adhering to these can confuse potential readers about the book's content.</li> <li><strong>Inconsistent branding:</strong> If you have a series or multiple books, ensure a consistent style across all covers to build a recognizable brand.</li></ol> <p>Would you like any specific advice on designing your cover?</p>",
                SuggestionData = new List<string>()
            });

            return promptResponseData;
        }

        public List<PromptResponseData> GetTemplatePromptResponseData()
        {
            return new List<PromptResponseData>
            {
                new PromptResponseData 
                {
                    Prompt = "Generate ideas for a new web products that might be popular in 2025?",
                    Response = "<p>Here are some web product ideas for 2025:</p> <ul><li><strong>AI-Powered Health Assistant:</strong> A platform offering personalized health advice and virtual consultations.</li> <li><strong>VR Shopping Mall:</strong> An immersive experience for exploring and purchasing items virtually.</li> <li><strong>Sustainable Living Hub:</strong> A resource for adopting eco-friendly lifestyles with community support.</li> <li><strong>Remote Work Suite:</strong> A tool for remote teams with project management, collaboration, and productivity features.</li></ul> <p>Which one stands out to you?</p>",
                    SuggestionData = new List<string> { "I like the AI health assistant idea!", "How can we ensure privacy with this Assistant?" }
                },
                new PromptResponseData 
                {
                    Prompt = "How do I set daily goals in my work day?",
                    Response = "<p>To stay focused and productive, try these steps for setting daily goals:</p> <ol><li><strong>Identify Priorities:</strong> List the most important tasks based on deadlines or significance.</li> <li><strong>Break Down Tasks:</strong> Split larger tasks into smaller, manageable steps.</li> <li><strong>Set SMART Goals:</strong> Make sure goals are Specific, Measurable, Achievable, Relevant, and Time-bound.</li> <li><strong>Time Blocking:</strong> Allocate specific times for each task to stay organized and on track.</li></ol> <p>Would you like more tips on any of these steps?</p>",
                    SuggestionData = new List<string> { "How do I prioritize tasks effectively?", "What tools or apps can help me prioritize tasks?" }
                },
                new PromptResponseData 
                {
                    Prompt = "Steps to publish a e-book with marketing strategy",
                    Response = "<p>To publish an e-book, follow the steps below:</p> <ol><li><strong>Write and format your e-book:</strong> Ensure your content is well-organized, edited, and formatted for digital reading.</li> <li><strong>Choose a publishing platform:</strong> Platforms like Amazon Kindle Direct Publishing (KDP) or Smashwords can help you publish and distribute your e-book.</li> <li><strong>Develop a marketing strategy:</strong> Utilize social media, email newsletters, and book promotion sites to create buzz and reach your target audience.</li> <li><strong>Launch and promote:</strong> Schedule a launch date, gather reviews, and continue promoting through various channels to maintain momentum and drive sales.</li></ol> <p>Do you have a specific topic in mind for your e-book?</p>",
                    SuggestionData = new List<string> { "How do I create an eye-catching e-book cover?", "What are common mistakes to avoid in e-book covers?" }
                },
                new PromptResponseData 
                {
                    Prompt = "I like the AI health assistant idea!",
                    Response = "<p>Great choice! An AI-powered personal health assistant could revolutionize how we manage our health. It could provide personalized health advice, track fitness goals, and even offer virtual consultations with healthcare professionals.</p> <p>Would you like to explore more features for this idea or discuss how it could be developed?</p>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData 
                {
                    Prompt = "How can we ensure privacy with this Assistant?",
                    Response = "<p>Ensuring user privacy with an AI-powered health assistant involves several key strategies:</p> <ol><li><strong>Data Encryption:</strong> Protect user data with strong encryption to prevent unauthorized access.</li> <li><strong>User Consent:</strong> Clearly inform users about data collection and obtain their explicit consent.</li> <li><strong>Anonymization:</strong> Use techniques to anonymize personal data, reducing identification risks.</li> <li><strong>Regular Audits:</strong> Perform privacy audits and comply with regulations like GDPR or HIPAA.</li></ol> <p>Would you like more details on any of these strategies?</p>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData 
                {
                    Prompt = "How do I prioritize tasks effectively?",
                    Response = "<p>To stay focused and productive, set daily goals by:</p> <ol><li><strong>Identifying Priorities:</strong> List important tasks based on deadlines or significance.</li> <li><strong>Breaking Down Tasks:</strong> Divide larger tasks into smaller, manageable steps.</li> <li><strong>Setting SMART Goals:</strong> Ensure goals are Specific, Measurable, Achievable, Relevant, and Time-bound. </li> <li><strong>Time Blocking:</strong> Schedule specific times for each task to stay organized.</li></ol> <p> Need more tips on any of these steps? </p>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData 
                {
                    Prompt = "What tools or apps can help me prioritize tasks?",
                    Response = "<p>Here are some tools to help you prioritize tasks effectively:</p> <ol><li><strong>Google Keep:</strong> For simple note-taking and task organization with labels and reminders.</li> <li><strong>Scoro:</strong> A project management tool for streamlining activities and team collaboration.</li> <li><strong>Evernote:</strong> Great for note-taking, to-do lists, and reminders.</li> <li><strong>Todoist:</strong> A powerful task manager for setting priorities and tracking progress.</li></ol> <p>Are you looking for tools to manage a specific type of task or project?</p>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData 
                {
                    Prompt = "How do I create an eye-catching e-book cover?",
                    Response = "<p>Creating an eye-catching e-book cover involves a few key steps:</p> <ol><li><strong>Understand your genre and audience:</strong> Research covers of popular books in your genre to see what appeals to your target readers.</li> <li><strong>Choose the right imagery and colors:</strong> Use high-quality images and a color scheme that reflects the tone and theme of your book.</li> <li><strong>Focus on typography:</strong> Select fonts that are readable and complement the overall design. The title should be prominent and easy to read even in thumbnail size.</li> <li><strong>Use design tools or hire a professional:</strong> Tools like Canva or Adobe Spark can help you create a professional-looking cover. Alternatively, consider hiring a graphic designer for a more polished result.</li></ol> <p>Would you like some tips on where to find good images or fonts for your cover?</p>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData 
                {
                    Prompt = "What are common mistakes to avoid in e-book covers?",
                    Response = "<p>Here are some common mistakes to avoid when designing an e-book cover:</p> <ol><li><strong>Cluttered design:</strong> Overloading the cover with too many elements can make it look messy and unprofessional. Keep it simple and focused.</li> <li><strong>Poor quality images:</strong> Using low-resolution or generic stock images can detract from the overall appeal. Always opt for high-quality, relevant visuals.</li> <li><strong>Unreadable fonts:</strong> Fancy or overly intricate fonts can be hard to read, especially in thumbnail size. Choose clear, legible fonts for the title and author name.</li> <li><strong>Ignoring genre conventions:</strong> Each genre has its own visual cues. Not adhering to these can confuse potential readers about the book’s content.</li> <li><strong>Inconsistent branding:</strong> If you have a series or multiple books, ensure a consistent style across all covers to build a recognizable brand.</li></ol> <p>Would you like any specific advice on designing your cover?</p>",
                    SuggestionData = new List<string>()
                }
            };
        }
    }
}
