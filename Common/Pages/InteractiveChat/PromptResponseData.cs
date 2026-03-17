#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.InteractiveChat;
using System.Collections.Generic;

namespace Syncfusion.Blazor.InteractiveChatDemo
{
    public class PromptResponseData
    {
        public string Prompt { get; set; } = string.Empty;
        public string Response { get; set; } = string.Empty;
        public List<string> SuggestionData { get; set; } = new List<string>();

        public class ConversationItem
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public long NumericId { get; set; }
        }

        public class ConversationData
        {
            public string Name { get; set; }
            public List<AssistViewPrompt> Prompts { get; set; }
            public List<string> PromptSuggestions { get; set; }
        }


        public List<string> GetAllSuggestionData()
        {
            return new List<string> { "How do I set daily goals in my work day?", "Steps to publish a e-book with marketing strategy" };
        }
        public List<string> GetStreamingSuggestionData()
        {
            return new List<string> {  "What are the main features of the AI AssistView component?", "What is Markdown and how is it used?" };
        }

        public List<string> GetAssistantSuggestionData()
        {
            return new List<string> { "How is AI used in everyday life?", "C# console app to manage library books" };
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

        public List<PromptResponseData> GetStreamingData()
        {
            List<PromptResponseData> streamingData = new List<PromptResponseData>
            {
                new PromptResponseData
                {
                    Prompt = "What are the main features of the AI AssistView component?",
                    Response = "The AI AssistView component offers several powerful features that enhance user interaction:\n\n- **Customizable Views:** Allows for custom templates to be used for banners, prompts, responses, and suggestions.\n- **Streaming Responses:** Provides real-time feedback as data is processed, enhancing immediacy and user engagement.\n- **Interactive Toolbar:** Easily integrates custom toolbar items, such as buttons and inputs, enhancing functionality.\n- **Seamless Integration:** Connects with AI services to provide advanced processing and intelligent responses.",
                    SuggestionData = new List<string> { "How can I customize the appearance of AI AssistView?", "What are the benefits of using Markdown?" }
                },
                new PromptResponseData
                {
                    Prompt = "How can I customize the appearance of AI AssistView?",
                    Response = "Customizing AI AssistView enables you to tailor the look and functionality to suit specific needs:\n\n- **Template Customization:** Modify templates for prompts, responses, and more.\n- **CSS Styling:** Apply custom styles to align with your application’s visual theme.\n- **Theme Support:** Utilize built-in themes or create your own for consistent styling.\n- **Banner and Toolbar Configurations:** Adjust content and tools for personalized UI experiences.",
                    SuggestionData = new List<string> { "What customization options are available in AI AssistView?", "What are the main features of the AI AssistView component?" }
                },
                new PromptResponseData
                {
                    Prompt = "What is Markdown and how is it used?",
                    Response = "Markdown is a straightforward syntax used primarily for formatting text documents:\n\n- **Headers:** Create headings with `#`, `##`, `###` for different levels.\n- **Emphasis:** Use `*text*` for italic and `**text**` for bold.\n- **Links and Images:** `[Link](URL)`, `![Alt Text](ImageURL)` to include links and images.\n- **Lists and Code Blocks:** Use `-` for lists and triple backticks ``` for code blocks.\n\nMarkdown’s simplicity and readability make it ideal for writing documentation.",
                    SuggestionData = new List<string> { "What are the benefits of using Markdown?", "What customization options are available in AI AssistView?" }
                },
                new PromptResponseData
                {
                    Prompt = "What customization options are available in AI AssistView?",
                    Response = "AI AssistView provides extensive customization options for tailored user interactions:\n\n- **Templates:** Use `<PromptItemTemplate>`, `<ResponseItemTemplate>`, etc., for customized display.\n- **Custom Toolbar Items:** Add buttons and other controls via `AssistViewToolbar`.\n- **Dynamic Content:** Update content based on user actions or external events.\n- **Styling:** Full CSS support for styling individual components and layouts.",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData
                {
                    Prompt = "What are the benefits of using Markdown?",
                    Response = "Markdown provides several benefits, especially in documentation and writing:\n\n- **Ease of Use:** Its syntax is simple and quick to learn, increasing productivity.\n- **Readability:** Plain text format ensures content is easy to read and edit.\n- **Flexibility:** Can be converted to HTML, PDF, and other formats easily.\n- **Collaboration:** Widely supported in various tools for collaborative writing and documentation.",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData
                {
                    Prompt = "Prime number checking C# example?",
                    Response = "<pre><code class=\"csharp language-csharp\">using System;\n\nclass Program\n{\n    static bool IsPrime(int n)\n    {\n        if (n <= 1) return false;\n        for (int i = 2; i <= Math.Sqrt(n); i++)\n            if (n % i == 0) return false;\n        return true;\n    }\n\n    static void Main()\n    {\n        Console.WriteLine(IsPrime(11)); // True\n    }\n}\n</code></pre>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData
                {
                    Prompt = "Generate Fibonacci sequence C# example?",
                    Response = "<pre><code class=\"csharp language-csharp\">using System;\n\nclass Program\n{\n    static void Fibonacci(int n)\n    {\n        int a = 0, b = 1, c;\n        for (int i = 0; i < n; i++)\n        {\n            Console.Write(a + \" \");\n            c = a + b;\n            a = b;\n            b = c;\n        }\n    }\n\n    static void Main()\n    {\n        Fibonacci(10); // 0 1 1 2 3 5 8 13 21 34\n    }\n}\n</code></pre>",
                    SuggestionData = new List<string>()
                }
            };
            return streamingData;
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
        public List<PromptResponseData> GetAssistantPromptResponseData()
        {
            return new List<PromptResponseData>
            {
                new PromptResponseData
                {
                    Prompt = "How is AI used in everyday life?",
                    Response = "<p>AI is integrated into many aspects of daily life. Common examples include:</p> <ol><li>Voice assistants like Siri and Alexa.</li><li>Recommendation systems on Netflix and YouTube.</li><li>Spam filters in email.</li><li>Navigation apps like Google MapsSmart home devices and appliances.</li><ol>",
                    SuggestionData = new List<string> { "C# console app to manage library books", "What are the benefits of using AI?" }
                },
                new PromptResponseData
                {
                    Prompt = "What are the benefits of using AI?",
                    Response = "<p>Artificial Intelligence (AI) is revolutionizing the way we live, work, and interact with the world. Here are the key benefits of using AI:<br></p><ol><li><strong>Automation of Repetitive Tasks:</strong> AI automates routine tasks, increasing efficiency and allowing humans to focus on creative and strategic work.</li><br><li><strong>Enhanced Decision-Making:</strong> AI analyzes large datasets to uncover patterns and insights, supporting better decisions in fields like finance, healthcare, and logistics.</li><br><li><strong>Personalization and Customer Experience:</strong> AI tailors experiences to individual users, improving satisfaction through personalized recommendations and services.</li><br><li><strong>Healthcare Advancements:</strong> AI improves diagnostics, treatment planning, and patient monitoring, enabling early disease detection and personalized medicine.</li><br><li><strong>Increased Productivity and Cost Savings:</strong> By optimizing processes and reducing errors, AI boosts productivity and lowers operational costs.</li><br><li><strong>Real-Time Data Processing:</strong> AI processes data in real time, enabling instant responses in areas like fraud detection, autonomous vehicles, and emergency services.</li><br><li><strong>Accessibility and Inclusion:</strong> AI-powered tools support people with disabilities through speech-to-text, real-time translation, and assistive technologies.</li><br><li><strong>Innovation and Scientific Discovery:</strong> AI accelerates research in fields like climate science, genomics, and space exploration by handling complex computations.</li><br><li><strong>Improved Safety and Security:</strong> AI enhances security through surveillance, threat detection, and predictive maintenance in industrial environments.</li><br><li><strong>Economic Growth and Job Creation:</strong> AI creates new roles in development, data science, and ethics, while fostering innovation and entrepreneurship.</li><br><li><strong>Environmental Sustainability:</strong> AI supports sustainability by optimizing energy use, improving agriculture, and guiding conservation efforts.</li><br><li><strong>Creative and Artistic Expression:</strong> AI contributes to the arts by generating music, visual art, and literature, opening new creative possibilities.</li></ol><br><p>In conclusion, AI offers transformative benefits across industries and society. When used responsibly, it can enhance human capabilities, solve complex problems, and drive progress in countless areas.</p>",
                    SuggestionData = new List<string> { "What are the risks or challenges of AI?", "C# console app to manage library books" }
                },
                new PromptResponseData
                {
                    Prompt = "What are the risks or challenges of AI?",
                    Response = "<p>While AI has many benefits, it also presents challenges such as:</p><ol><li><strong>Bias:</strong> AI can reflect and amplify biases in training data.</li><li><strong>Privacy:</strong> AI systems often rely on large amounts of personal data.</li> <li><strong>Job Displacement:</strong> Automation may replace certain human jobs.</li></ol>",
                    SuggestionData = new List<string> { "How is AI used in everyday life?", "C# console app to manage library books" }
                },
                new PromptResponseData
                {
                    Prompt = "C# console app to manage library books",
                    Response = "<p>Creating a C# console application for Library Management involves building a simple system to manage books, members, and transactions like borrowing and returning books. Here's a basic structure to get you started:</p><ol><li><strong>Features to Include:</strong><ul><li>Add/Remove Books</li><li>Register Members</li><li>Borrow/Return Books</li><li>View Book List</li><li>View Member List</li></ul></li><li><strong>Project Structure:</strong><ul><li>Book</li><li>Member</li><li>Library</li><li>Program</li></ul></li></ol><pre><code class=\"csharp language-csharp\">using System;\nusing System.Collections.Generic;\n\nclass Book {\n    public int Id { get; set; }\n    public string Title { get; set; }\n    public bool IsBorrowed { get; set; } = false;\n}\n\nclass Member {\n    public int Id { get; set; }\n    public string Name { get; set; }\n}\n\nclass Library {\n    private List<Book> books = new List<Book>();\n    private List<Member> members = new List<Member>();\n\n    public void AddBook(string title) {\n        int id = books.Count + 1;\n        books.Add(new Book { Id = id, Title = title });\n        Console.WriteLine($\"Book '{title}' added with ID {id}.\");\n    }\n\n    public void RegisterMember(string name) {\n        int id = members.Count + 1;\n        members.Add(new Member { Id = id, Name = name });\n        Console.WriteLine($\"Member '{name}' registered with ID {id}.\");\n    }\n\n    public void BorrowBook(int bookId) {\n        var book = books.Find(b => b.Id == bookId);\n        if (book != null && !book.IsBorrowed) {\n            book.IsBorrowed = true;\n            Console.WriteLine($\"Book '{book.Title}' borrowed.\");\n        } else {\n            Console.WriteLine(\"Book not available.\");\n        }\n    }\n\n    public void ReturnBook(int bookId) {\n        var book = books.Find(b => b.Id == bookId);\n        if (book != null && book.IsBorrowed) {\n            book.IsBorrowed = false;\n            Console.WriteLine($\"Book '{book.Title}' returned.\");\n        } else {\n            Console.WriteLine(\"Invalid return.\");\n        }\n    }\n\n    public void ListBooks() {\n        foreach (var book in books) {\n            Console.WriteLine($\"ID: {book.Id}, Title: {book.Title}, Borrowed: {book.IsBorrowed}\");\n        }\n    }\n\n    public void ListMembers() {\n        foreach (var member in members) {\n            Console.WriteLine($\"ID: {member.Id}, Name: {member.Name}\");\n        }\n    }\n}\n\nclass Program {\n    static void Main() {\n        Library library = new Library();\n        while (true) {\n            Console.WriteLine(\"\\nLibrary Menu:\\n1. Add Book\\n2. Register Member\\n3. Borrow Book\\n4. Return Book\\n5. List Books\\n6. List Members\\n7. Exit\");\n            Console.Write(\"Choose an option: \");\n            int choice = int.Parse(Console.ReadLine());\n\n            switch (choice) {\n                case 1:\n                    Console.Write(\"Enter book title: \");\n                    library.AddBook(Console.ReadLine());\n                    break;\n                case 2:\n                    Console.Write(\"Enter member name: \");\n                    library.RegisterMember(Console.ReadLine());\n                    break;\n                case 3:\n                    Console.Write(\"Enter book ID to borrow: \");\n                    library.BorrowBook(int.Parse(Console.ReadLine()));\n                    break;\n                case 4:\n                    Console.Write(\"Enter book ID to return: \");\n                    library.ReturnBook(int.Parse(Console.ReadLine()));\n                    break;\n                case 5:\n                    library.ListBooks();\n                    break;\n                case 6:\n                    library.ListMembers();\n                    break;\n                case 7:\n                    return;\n                default:\n                    Console.WriteLine(\"Invalid option.\");\n                    break;\n            }\n        }\n    }\n}</code></pre>",
                    SuggestionData = new List<string>()
                },
                new PromptResponseData
                {
                    Prompt = "Prime number checking C# example?",
                    Response = "<pre><code class=\"csharp language-csharp\">using System;\n\nclass Program\n{\n    static bool IsPrime(int n)\n    {\n        if (n <= 1) return false;\n        for (int i = 2; i <= Math.Sqrt(n); i++)\n            if (n % i == 0) return false;\n        return true;\n    }\n\n    static void Main()\n    {\n        Console.WriteLine(IsPrime(11)); // True\n    }\n}\n</code></pre>",
                    SuggestionData = new List<string>()
                }
            };
        }
    }
}
