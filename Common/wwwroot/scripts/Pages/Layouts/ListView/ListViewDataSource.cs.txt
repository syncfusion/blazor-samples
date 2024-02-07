#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Layouts.ListView
{
    public static class ListViewDataSource
    {
        public static List<NewsDataModel> NewsData = new List<NewsDataModel>() {
            new NewsDataModel {
                Title = "IBM Open-Sources WebSphere Liberty Code",
                Description = "In late September, IBM announced that it would be open-sourcing the code for WebSphere...",
                Content = "In late September, IBM announced that it would be open-sourcing the code for" + " WebSphere Liberty, an application server intended to facilitate the development of Java" + "apps and microservices. Liberty is intended to allow developers to quickly develop and" + "deploy applications in a variety of environments while functioning seamlessly with other" + "solutions. IBM will continue to offer commercial versions of Liberty that include access to" + "dedicated technical support and advanced capabilities, but the core of the software will be" + "available to any developer. By open-sourcing the code, IBM hopes to make Liberty a" + "relevant piece of software for some time to come while further improving the Java" + "development community. This fits in well with IBM’s earlier open-source contributions," + "including Eclipse OpenJ9. In fact, with WebSphere Liberty, Eclipse OpenJ9, Eclipse" + "MicroProfile—which  IBM was a founding member of—and Java EE, it is possible to have a" + "fully open-licensed Java stack model to build, test, run, and scale Java applications. This" + "is fantastic news for Java developers, and an excellent opportunity to further the" + "standards of Java development for the entire community. Are you a Java developer?" + "What do you think of this development? Let us know in the comments below or on Facebook or" + " Twitter. "
            },

            new NewsDataModel {
                Title = "Must Reads: 5 Big Data E-books to upend your development",
                Description = "Did you know our first e-book was published in May 2012? jQuery Succinctly was the start of over...",
                Content = "Did you know our first e-book was published in May 2012? jQuery Succinctly was" + "the start of over one hundred free e-books written to help developers get free access to" + "software development resources and strategies. Capturing and understanding big data is by" + "far one of the most-asked-about topics across both our support and learning" + "sites. Ranked in order of popularity, here are Succinctly e-books related to big data" + "to add to your reading list: 5. Hadoop Succinctly An Apache open source project" + ", Hadoop stores huge amounts of data in safe, reliable storage and runs complex queries" + "over data in an efficient way. It is at the core of a whole host of the most popular big" + "data tools. Mastering Hadoop ensures you get the best out of all these tools and better" + "insight from your data. Elton Stoneman’s Hadoop Succinctly explains how Hadoop works, what" + "goes on in the cluster, demonstrating how to move data in and out of Hadoop, and how to" + "query it efficiently. It also walks through a Java MapReduce example, illustrates how to" + "write the same query in Python and .NET, and discusses the wider Hadoop ecosystem. 4. " + "Cassandra Succinctly Apache Cassandra is an open-source distributed database system" + "noted for its consistency, its ability to run on commodity hardware, and its easy" + "deployment to cloud infrastructure. With Cassandra Succinctly by Marko Švaljek, you will" + "learn the architecture behind Cassandra that makes it a reliable system, including how" + "hashes are used to identify where data is stored, how choosing the right replication factor" + "can enhance or hinder performance, and how the system handles updating and deleting data." + "By the end of the book, you will be able to store and model data using the Cassandra Query" + "Language, and use Cassandra within your own applications. 3. Spark" + "Succinctly Mastering big data requires an aptitude at every step of information" + "processing. Post-processing, one of the most important steps, is where you find Apache" + "Spark frequently employed. Spark Succinctly, by Marko Švaljek, addresses Spark’s use in the" + "ultimate step in handling big data. This e-book, the third installment in Švaljek’s IoT" + "series, teaches the basics of using Spark and explores how to work with RDDs, Scala and" + "Python tasks, JSON files, and Cassandra. 2. Neural Networks Using C#" + "Succinctly Neural networks are an exciting field of software development used to" + "calculate outputs from input data. While the idea seems simple enough, the implications of" + "such networks are staggering—think optical character recognition, speech recognition, and" + "regression analysis. With Neural Networks Using C# Succinctly by James McCaffrey, you\"ll" + "learn how to create your own neural network to solve classification problems, or problems" + "where the outcomes can only be one of several values. Learn about encoding and normalizing" + "data, activation functions and how to choose the right one, and ultimately how to train a" + "neural network to find weights and bias values that provide accurate predictions. 1. " + "Data Capture and Extraction with C# Succinctly Capturing and extracting information" + "is one of the most important tasks a developer can perform, and making this task more" + "engaging without relying entirely on specialized tools is an efficient way to improve" + "productivity. In Data Capture and Extraction with C# Succinctly, author Ed Freitas guides" + "readers toward getting more out of C# in minimal time. Let us know which one is your" + "favorite in the comments! "
            },
            new NewsDataModel {
                Title = "The Syncfusion Global License: Your Questions, Answered ",
                Description = "Syncfusion recently hosted a webinar to cover the ins and outs of the Syncfusion global...",
                Content = "Syncfusion recently hosted a webinar to cover the ins and outs of the" + "Syncfusion global license. We received many questions about the license, and our client" + "relations team, led by Pat Staley, has provided answers. Read on for a full overview of the" + "Syncfusion global license, or visit Syncfusion’s YouTube channel to watch the webinar in" + "full. Q: Regarding the free license for companies with 5 developers or less than $1m" + "in annual revenue: when does that license expire? A: The Community License has" + "several criteria that make it distinct from the global license, so there is no single" + "answer to that question. Any customers with questions about the Community License should" + "contact a Syncfusion sales representative. Q: Our business line in health care" + "requires that we obtain business agreements with contractors and vendors. Has Syncfusion" + "signed these kinds of BAs in the past? A: We work with many companies that request" + "such documents, and we can always put you in touch with our legal team for" + "specifics. Q: We develop products. If we want to use dashboards, do our clients need" + "to buy the Dashboard Server or is it royalty-free? A: Please contact" + "clientrelations@syncfusion.com with your contact information and company details. In" + "situations like this, we work with our clients to reach the best solution; there is no" + "single answer. Q: Is there a time limit? A: Our license model reflects a 1-year" + "term unless you make other arrangements during the sales process. Q: Can I use my" + "global license to create software that has Syncfusion controls embedded within it and sell" + "this software to my clients, or does that require a reseller or runtime license? A:" + "If you are providing an end-product to your client, and additional coding will not be" + "needed, you may sell your software to your client with just the global license. If the" + "software requires additional work over time, you will need to speak with your Syncfusion" + "sales representative to ensure you have the correct license. Q: When does my license" + "expire? A: You can log into your portal and view the expiration date under License" + "and Keys. Q:  Who is my client relations representative? A:  Please send an" + "email to clientrelations@syncfusion.com and we will be happy to have your dedicated client" + "relations representative reach out to you. Q:  How do I get added to a portal?" + " A:  Reach out to your portal administrator, or send an email to" + "clientrelations@syncfusion.com and we will reach out to you to assist. Q:  The portal" + "shows my license is expired. How do I get this updated? A: Please contact your portal" + "administrator to ensure that you are added to the portal, or you can contact" + "clientrelations@syncfusion.com and our team will assist you. Q:  Why don’t I see the" + "global license under My Orders? A:  The order may be under a different profile; only" + "orders placed under your login will show. Q:  Is the purchase price a one-time fee?" + " A:  The global license is a subscription, renewing annually unless otherwise" + "negotiated. Q:  Is support charged separately? A:  No, all support is included" + "in your standard license subscription. However, we do offer consulting services for custom" + "development separate from the global license. You can contact" + "clientrelations@syncfusion.com for more information on consulting if you are" + "interested. Q:  I have contractors that do my development. Are they covered by the" + "global license? A:  They can be! The flat license structure (project, division, and" + "global) is designed for use by third-party contractors. If that is requested and agreed" + "upon, we will include that information in your Master License Agreement. Q:  What is" + "the benefit of including all my users in the portal? A:  Developers can see support" + "incidents created within the portal and can receive patches and updates so users are all" + "working on the same version of Syncfusion. Our client relations team also monitors accounts" + "to ensure that you do not have an excessive amount of support incidents open at one time." + "Ensuring that all of your users are in the portal helps us to manage your account and" + "incidents. Q:  Can you tell me more about the client relations department? A: " + "The CRD is your trusted advisor within Syncfusion. You will have direct contact with a" + "representative who can assist with service, support, and product education, and who can be" + "the ally you need for your development. Q:  If I have a flat license, do I have to" + "update Syncfusion with users I need added to the portal? A:  Syncfusion does not need" + "to be notified when a user needs to be added. Q:  Why would I want to create a new" + "portal each time I start a new project? A:  Not only is this a great organizational" + "feature that keeps your projects autonomous from one another, each portal can support a" + "different product version, allowing you to upgrade each project as needed. There is no" + "co-dependency here. Q:   Do I have to assign a platform or component to each project?" + "What if I have multiple components being used on one project? A:  The only time" + "Syncfusion will ask you to associate a platform or component with a project is during" + "incident creation. You can use multiple controls or components on one project, but only if" + "the components are using the same product version. As mentioned, the portal can only" + "support one product version at a time. "
            },
            new NewsDataModel {
                Title = "Interview with Application Security in .NET Succinctly Author Stan Drapkin ",
                Description = "The following is a short interview with Succinctly series author Stan Drapkin, whose latest book...",
                Content = "The following is a short interview with Succinctly series author Stan Drapkin, whose latest book" + "Application Security in .NET Succinctly was published on Tuesday, October 12. You can download the book" + "here. What should people know about application security in the .NET Framework? Why is it important?" + " Microsoft’s .NET Framework ushered a new era of rapid application development that was almost as powerful as" + "C/C++ development on one hand, but did not have as many sharp edges and opportunities to shoot yourself in the" + "foot on the other hand. The unfortunate side effect was that .NET developers\" efforts were mostly spent" + "discovering and calling the APIs provided by the .NET ecosystem, not learning how to use these APIs correctly. Many" + "of the .NET security-related APIs are not safe to use by a casual .NET developer. This book tries to raise" + "awareness of many important application security topics that most .NET developers are bound to run into. The" + "importance of understanding the challenges and pitfalls of application security is hard to underestimate. The" + "security breaches are happening weekly if not daily, and their scope and magnitude continue to grow as users" + "entrust (or are forced to entrust) more of their information to digital repositories and their" + "operators. When did you first become interested in application security? I became interested in" + "application security through a fascination with cryptography when I was 15 years old. I wrote an unbreakable" + "XOR-based encryption mechanism in Turbo Pascal that I was very proud of. As laughable as it is now, I\"m sure many" + "folks in the security field have a similar story to share. The writings of Bruce Schneier fueled my interest and" + "made me realize that the information security domain is too focused on cryptographic tools and primitives, and not" + "focused enough on how to use these tools to engineer secure systems. By writing this e-book, did you learn" + "anything new yourself? I learned that application security and security in general are difficult topics to" + "write about. Unlike basic things like math or computer science, application security is a rapidly moving and" + "evolving field, with new threats, vulnerabilities, exploits, and countermeasures arriving nonstop. The prescriptive" + "do X, Y, and Z to be safe approach to security might work today, but is inadequate tomorrow. Rather than giving" + "readers a fish, I’ve tried to teach them how to fish in hopes that a foundational understanding of core concepts" + "will provide longer-term value. How will application security change over the next few years? I think" + "the security field has come to a threshold where it will start to be regulated. The amount of incompetence and" + "negligence in this field is only matched by the magnitude of damages, and that creates a lethal combination that" + "everyone in our digital economy suffers from. We already regulate doctors, lawyers, pilots, and many other" + "professions, as well as organizations employing them. I think that the regulatory changes will affect not" + "only the technical in-the-field professionals, but will also impact the C-suite, and force senior leadership to" + "give security pros a seat at the table. One of the highlights of this profound lack of senior-level understanding" + "was in the Equifax Personnel-Change statement that followed the recent massive Equifax data breach. Equifax" + "appointed a new Chief Security Officer (CSO), and made the CSO report to the CIO. When the just-been-breached" + "Equifax does not understand why the CSO must report to the CEO and not the CIO, that\"s another sign that executive" + "leadership still does not have the right perspective on security. Another industry-wide change in perspective" + "that I’m anticipating is a shift from “defend the castle” to “inmates are running the asylum.” Insider threats are" + "already among the main security threats of 2017, and yet most security efforts are still just building" + "walls. Do you see the application security as part of a larger trend in software development? I believe" + "that thinking of application security as a larger trend in software development is like thinking of mathematics as" + "a larger trend in physics, or thinking of backups as a larger trend in disaster recovery. Not everyone must be a" + "highly skilled application-security professional, just like not everyone must be a highly-skilled accountant," + "lawyer, or engineer. Yet most IT companies rely on professional services of a relatively small number of skilled" + "experts with unique domains of expertise. As software continues to eat the world, software development as a field" + "has long been vast enough and important enough to warrant domain specializations. Boeing does not advertise" + "full-stack aerospace engineer positions, and yet one of the core career areas for Boeing is cybersecurity." + "Ten years ago, every company became a software company. In 2017, every software company must become a" + "cybersecurity-focused company. Cybersecurity begins in the C-suite. What other books or resources on" + "application security do you recommend? Microsoft’s Security Development Lifecycle book is a good read for" + "software development managers and architects. Those interested in the foundations of cryptography may find Crypto" + "101 or the Serious Cryptography book suitable. Those interested in the fundamentals of TLS, the largest application" + "of cryptography to the web, should check out Bulletproof SSL and TLS. Tangled Web is another favorite of mine," + "which covers the insanity of the modern web. "
            },
            new NewsDataModel {
                Title = "Guest Blog: Exporting the data grid to a specific PDF page in Xamarin.Forms",
                Description = "This guest blog post was written by Dave Lasike. He can be found on Twitter at @davelasike...",
                Content = "This guest blog post was written by Dave Lasike. He can be found on Twitter at" + "@davelasike. Recently I was asked to prototype a cross-platform application for a community-based education" + "provider. The application was designed to replace a form being used to assess students’ driving abilities. The" + "tricky part came when deciding how to display the assessment sheet, a grid displaying driving assessment data, in a" + "mobile application. My initial thinking was to do something like a list view within a list view, or a custom grid" + "with rows and columns containing buttons within each cell. However, Syncfusion’s data grid control for" + "Xamarin.Forms provided an easy out-of-the-box solution to do what we needed, and allowed us to customize a range of" + "features to meet the client’s requirements. With the release of Essential Studio 2017 Volume 3 Service Pack 2" + "(version 15.3.0.33), a StartPageIndex property was added, which allows you to specify which page in a PDF document" + "you want the data grid control to be rendered to. Previous to this release, the data grid could only be" + "rendered to the first page of a PDF document. This wasn’t a bad thing, but if you tried to create a PDF document" + "based on a specific design, you had a great control that worked well across mobile platforms but could only be" + "rendered on the first page of every PDF document as opposed to a specific page, which often conflicted with what we" + "needed to achieve. The first step was to clear out the portable class library that is generated when creating" + "a Xamarin.Forms project. If you haven’t considered using .NET Standard, there are several blog posts online that" + "show how to implement a .NET Standard library into your project (see this post from Nick Randolph in particular)." + "There are also blog posts that show how to install PCL NuGet packages into .NET Standard libraries (see this post" + "from James Montemagno). Once the .NET Standard library was up and running, it was time to take a look at" + "Syncfusion’s data grid control. To use it, you need to import the appropriate Syncfusion NuGet packages." + "Implementing the control is relatively easy. The Syncfusion documentation is excellent. With small code snippets," + "getting started and testing out the controls is a case of just reading through the documentation, copying the code" + "snippet, and playing around to suit your needs. I won’t cover creating the data grid control or creating the model" + "here, as those are covered extensively in the getting started documentation. What I want to focus on is the" + "StartPageIndex property and how to implement it into your code when generating a PDF document with the data grid" + "control. At the time of this writing, there is no documentation on the StartPageIndex property. However, it is" + "fairly easy to implement given it is an int that takes the page number you want to render the control to. In" + "my case, I had a page that I wanted to create before the data grid. To do this, I created the PDF document, added" + "the required pages, and then added the data grid control to the second page. The following image shows the" + "data grid being rendered to the second page in the PDF document. Data grid rendered on the second page of the" + "PDF document This was a quick overview of how to render the data grid control to a specific page using the" + "StartPageIndex property. As you can see from the screenshot, there is a range of customizations (e.g., different" + "colored cells) that you can add to your data grid and render to PDF if required by attaching to the different" + "events that are raised when generating the PDF. "
            },
            new NewsDataModel {
                Title = "What’s Coming from Microsoft this Fall",
                Description = "On October 17, Microsoft will release its Fall Creators Update for the Windows 10 platform...",
                Content = "On October 17, Microsoft will release its Fall Creators Update for the Windows 10 platform. Much like" + "its previous counterpart, the Spring Creators Update, the release is set to deliver more features to Windows 10 for" + "both developers and users, with particular emphasis this time around on app modernization, mixed reality, and game" + "development and software updates. App modernization is the term Microsoft used in its press event to" + "encompass the features that will affect most Windows 10 users and developers. The updates primarily serve to make" + "using Windows 10 easier and more productive all around. Some significant highlights include device relay, which" + "allows you to continue a project you’re currently working on on a different device, whether it’s Windows, iOS, or" + "Android; activity feed, which lets you pick up where you left off in a past project; and OneDrive files on-demand," + "where you can access your OneDrive files through Windows File Explorer immediately without having to download them" + "first. Another significant modernization update is the Fluent Design System, which seems to be the next" + "descendant of the Modern UI design that was launched with the Windows 8 OS. Like its parent designs, the Fluent" + "Design System is intended to provide a more pleasurable and intuitive UI experience, one that will behave the same" + "across desktop, tablet, mobile, and even virtual reality devices. The UI changes in the new design are subtle but" + "omnipresent, mostly tweaking things like lighting, motion, and scale to bring a new depth to interactive elements." + "Finally, the Fall Creators Update is also delivering much-demanded tweaks to update and privacy options that have" + "often been obscured or unavailable, to give users finer control over their machines. Fluent Design UI." + "Source: Microsoft. Mixed reality is on the spectrum between virtual reality, fully immersive experiences" + "provided by devices like the Oculus Rift, and augmented reality, experiences that overlay digital images on the" + "physical world like the Microsoft HoloLens. The Fall Creators Update opens up Windows 10 to new mixed reality" + "devices from prominent manufacturers like Acer, Dell, and Lenovo. These devices are unique additions to the reality" + "ecosystem for their simple setup and low cost barrier. The headsets start at $399, and all it takes to use them is" + "to plug them into your Windows machine via HDMI and USB cables. No external cameras or cumbersome accessories to" + "set up. All Windows mixed reality apps are built on the Universal Windows Platform, and developers can begin" + "working on apps for the new devices right now with developer kits offered by Acer and HP. The HP Windows" + "Mixed Reality Headset On the gaming front, the Fall Creators Update aims to improve UWP games through greater" + "resources available on the Xbox One, meaning more CPU cores, more RAM, and full access to the GPU. In addition, a" + "new Xbox Live Creators Program provides game developers a simpler certification process for getting their games" + "published, and full access to Xbox Live features like leaderboards, statistics, and cloud saves. Game developers" + "are also being given greater control over how their games are offered in the Store, with the ability to manage" + "release dates, subscription add-ons, sales to existing customers, game trailers, and more. With the insane rise of" + "video game streaming over the past couple years, perhaps the most impressive update for gamers in the Fall Creators" + "Update is the new Mixer app, a streaming app capable of supporting four simultaneous players that provides deep" + "viewer interactivity rarely found in other streaming services. It’s not only a streaming service, but also a" + "development platform for building custom interactive integrations. Mixer is built into Windows 10 and Xbox One," + "allowing millions of gamers to begin streaming from their devices with only a few clicks and little to no" + "code. Many Fall Creators Update features affect the Xbox One. These are just a handful of the dozens of" + "updates coming on October 17. For more insights, you can check out the numerous videos available on Windows Dev" + "Center that highlight these features and more, like increased Windows Ink compatibility, new UWP and Xamarin" + "features, and Visual Studio improvements. Right now, developers can download the Windows 10 Fall Creators Update" + "SDK to begin preparing their apps for the October 17 release. What are some of your most anticipated features" + " Let us know in the comments below, or on Twitter and Facebook. We’re pretty excited about annotation support in" + "EPUBs coming to Microsoft Edge! "
            },
            new NewsDataModel {
                Title = "Employees Wake Up and Lace Up for Making Strides",
                Description = "The American Cancer Society reports that each year collectively more than one million people...",
                Content = "The American Cancer Society reports that each year collectively more than one" + "million people participate in nearly 300 Making Strides Against Breast Cancer events in the" + "US, raising at least $60 million. That’s why this weekend a number of Syncfusion employees" + "from the client relations, marketing, and sales teams will lace up their shoes to" + "participate in Raleigh’s Making Strides Against Breast Cancer event, happening this" + "Saturday morning, October 14, at Midtown Park Event Stage. Team Brett-y and the Jets," + "assembled by Enterprise License Renewal Representative Brett Jarrett, will take an early" + "morning walk around Raleigh to help raise funds, increase awareness, and consolidate a" + "community in the fight against breast cancer. They invite you to join in the walk, or" + "make a donation to the cause. Making Strides Information Where: Midtown Park" + "Event Stage, Raleigh, NC When: Saturday, October 14, 2017 Time: Check-in at" + "7:30 AM, opening ceremony at 8:00 AM, walk begins at 9:15 AM Video: " + "https://www.youtube.com/watch?v=QaAy1tW0xbE Website:" + "http://main.acsevents.org/site/TR?pg=entry&fr_Id=84845  "
            }
        };

        public static List<NewsDataModel> DataSource = new List<NewsDataModel>() {
            new NewsDataModel {
                Id = "01",
                Title = NewsData[0].Title,
                Description = NewsData[0].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template1",
                TimeStamp = "Syncfusion Blog - October 19, 2017",
                Child = new List < NewsDataModel > () {
                    new NewsDataModel {
                        Id = "01_1",
                        Title = NewsData[0].Title,
                        Category = NewsData[0].Title,
                        Text = NewsData[0].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[0].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "02",
                Title = NewsData[1].Title,
                Description = NewsData[1].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template2",
                TimeStamp = "Syncfusion Blog - October 18, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "02_1",
                        Title = NewsData[1].Title,
                        Category = NewsData[1].Title,
                        Text = NewsData[1].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[1].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "03",
                Title = NewsData[2].Title,
                Description = NewsData[2].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template3",
                TimeStamp = "Syncfusion Blog - October 18, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "03_1",
                        Title = NewsData[2].Title,
                        Category = NewsData[2].Title,
                        Text = NewsData[2].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[2].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "04",
                Title = NewsData[3].Title,
                Description = NewsData[3].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template4",
                TimeStamp = "Syncfusion Blog - October 18, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "04_1",
                        Title = NewsData[3].Title,
                        Category = NewsData[3].Title,
                        Text = NewsData[3].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[3].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "05",
                Title = NewsData[4].Title,
                Description = NewsData[4].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template5",
                TimeStamp = "Syncfusion Blog - October 17, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "05_1",
                        Title = NewsData[4].Title,
                        Category = NewsData[4].Title,
                        Text = NewsData[4].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[4].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "06",
                Title = NewsData[5].Title,
                Description = NewsData[5].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template6",
                TimeStamp = "Syncfusion Blog - October 17, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "06_1",
                        Title = NewsData[5].Title,
                        Category = NewsData[5].Title,
                        Text = NewsData[5].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[5].Content
                    }
                }
            },
            new NewsDataModel {
                Id = "07",
                Title = NewsData[6].Title,
                Description = NewsData[6].Description,
                Text = "Syncfusion Blog",
                ImgSrc = "blazor-listview-template7",
                TimeStamp = "Syncfusion Blog - October 13, 2017",
                Child = new List < NewsDataModel > {
                    new NewsDataModel {
                        Id = "07_1",
                        Title = NewsData[6].Title,
                        Category = NewsData[6].Title,
                        Text = NewsData[6].Title,
                        ImgSrc = "",
                        Heading = "",
                        TimeStamp = "",
                        Description = NewsData[6].Content
                    }
                }
            }

        };

        public static List<CallHistoryModel> CallHistories = new List<CallHistoryModel>() {
            new CallHistoryModel {
                Text = "Smith",
                Id = "received-01",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "2 hours ago",
                Category = "Today"
            },
            new CallHistoryModel {
                Text = "Johnson",
                Id = "received-02",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Williams",
                Id = "missed-01",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "4 hours ago",
                Category = "Today"
            },
            new CallHistoryModel {
                Text = "Jones",
                Id = "missed-02",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Katherine",
                Id = "received-03",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Anderson",
                Id = "received-04",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "12 hours ago",
                Category = "Today"
            },
            new CallHistoryModel {
                Text = "Williams",
                Id = "received-06",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Smith",
                Id = "missed-03",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Emily",
                Id = "missed-04",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "14 hours ago",
                Category = "Today"
            },
            new CallHistoryModel {
                Text = "Johnson",
                Id = "missed-05",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Jones",
                Id = "missed-06",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "18 hours ago",
                Category = "Today"
            },
            new CallHistoryModel {
                Text = "Anderson",
                Id = "missed-07",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Smith",
                Id = "missed-08",
                Icon = "e-custom",
                Type = "missed",
                Group = "Missed",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Arianna",
                Id = "received-05",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "Yesterday",
                Category = "Yesterday"
            },
            new CallHistoryModel {
                Text = "Katherine",
                Id = "received-07",
                Icon = "e-custom",
                Type = "received",
                Group = "Received",
                Time = "Yesterday",
                Category = "Yesterday"
            }
        };

        public static List<CallHistoryModel> GetReceivedData()
        {
            List<CallHistoryModel> temp = new List<CallHistoryModel>();
            foreach (CallHistoryModel item in CallHistories)
            {
                if (item.Type == "received")
                {
                    temp.Add(item);
                }
            }
            return temp;
        }

        public static List<CallHistoryModel> GetMissedData()
        {
            List<CallHistoryModel> temp = new List<CallHistoryModel>();
            foreach (CallHistoryModel item in CallHistories)
            {
                if (item.Type == "missed")
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
    }

    public class CallHistoryModel
    {
        public string Text
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public string Icon
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
    }

    public class NewsDataModel
    {
        public string Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string Text
        {
            get;
            set;
        }
        public string ImgSrc
        {
            get;
            set;
        }
        public string TimeStamp
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Heading
        {
            get;
            set;
        }
        public string Content
        {
            get;
            set;
        }
        public List<NewsDataModel> Child
        {
            get;
            set;
        }
    }
}