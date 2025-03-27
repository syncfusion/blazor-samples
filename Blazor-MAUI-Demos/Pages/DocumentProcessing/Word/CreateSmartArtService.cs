#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Office;
using HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment;

namespace Blazor_MAUI_Demos.Pages.DocumentProcessing.Word
{
    public class CreateSmartArtService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CreateSmartArtService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Create SmartArt in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream CreateSmartArt(string smartArtType)
        {
            // Create a new document
            WordDocument document = new WordDocument();
            // Load the template.
            document.Open(fileDataValue["create-smartart-input.docx"], FormatType.Docx);

            switch (smartArtType)
            {
                case "List":
                    // Create a List SmartArt diagram.
                    CreateListSmartArt(document);
                    break;
                case "Process":
                    // Create a Process SmartArt diagram.
                    CreateProcessSmartArt(document);
                    break;
                case "Cycle":
                    // Create a Cycle SmartArt diagram.
                    CreateCycleSmartArt(document);
                    break;
                case "Hierarchy":
                    // Create a Hierarchy SmartArt diagram.
                    CreateHierarchySmartArt(document);
                    break;
                case "Relationship":
                    // Create a Relationship SmartArt diagram.
                    CreateRelationshipSmartArt(document);
                    break;
                case "Matrix":
                    // Create a Matrix SmartArt diagram.
                    CreateMatrixSmartArt(document);
                    break;
                case "Pyramid":
                    // Create a Pyramid SmartArt diagram.
                    CreatePyramidSmartArt(document);
                    break;
                case "Picture":
                    // Create a Picture SmartArt diagram.
                    CreatePictureSmartArt(document);
                    break;
            }

            //Save the document as a stream and return the stream
            MemoryStream stream = new MemoryStream();
            //Save the created Word document to MemoryStream
            document.Save(stream, FormatType.Docx);
            document.Close();
            stream.Position = 0;
            return stream;
        }
        /// <summary>
        /// Creates a list SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateListSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];
            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange = paragraph.AppendText("Project Planning List");
            textRange.CharacterFormat.FontSize = 28f;
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Vertical Chevron List" layout.
            WSmartArt verticalChevronListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.VerticalChevronList, 432, 252);

            // Add the "Planning" phase node.
            IOfficeSmartArtNode planningNode = verticalChevronListSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(planningNode, "Set clear objectives.", "Allocate resources effectively.", 23f);

            // Add the "Execution" phase node.
            IOfficeSmartArtNode executionNode = verticalChevronListSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(executionNode, "Assign tasks to the team.", "Track progress regularly.", 23f);

            // Add the "Review" phase node.
            IOfficeSmartArtNode reviewNode = verticalChevronListSmartArt.Nodes[2];
            reviewNode.TextBody.Text = "Review";
            reviewNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(reviewNode, "Analyze outcomes.", "Identify lessons learned.", 23f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Horizontal BulletList" layout
            WSmartArt horizontalBulletListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.HorizontalBulletList, 432, 252);
            // Add the "Planning" phase node.
            planningNode = horizontalBulletListSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(planningNode, "Set clear objectives.", "Allocate resources effectively.", 20f);

            // Add the "Execution" phase node
            executionNode = horizontalBulletListSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(executionNode, "Assign tasks to the team.", "Track progress regularly.", 20f);

            // Add the "Review" phase node
            reviewNode = horizontalBulletListSmartArt.Nodes[2];
            reviewNode.TextBody.Text = "Review";
            reviewNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            AddSmartArtChildNode(reviewNode, "Analyze outcomes.", "Identify lessons learned.", 20f);
        }

        /// <summary>
        /// Creates a Process SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateProcessSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Healthy Lifestyle Journey");
            textRange1.CharacterFormat.FontSize = 28f;
            textRange1.CharacterFormat.FontName = "Times New Roman";
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Segmented Process" layout
            WSmartArt segmentedProcessSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.SegmentedProcess, 432, 252);

            // Add the "Start" phase node
            IOfficeSmartArtNode startProcess = segmentedProcessSmartArt.Nodes[0];
            startProcess.TextBody.Text = "Start";
            startProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(startProcess, "Begin exercise and eat balanced meals.", "Stay hydrated and prioritize sleep.", 12f);

            // Add the "Track" phase node
            IOfficeSmartArtNode trackProcess = segmentedProcessSmartArt.Nodes[1];
            trackProcess.TextBody.Text = "Track";
            trackProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(trackProcess, "Record physical activity and food intake.", "Use a fitness app or journal.", 12f);

            // Add the "Sustain" phase node
            IOfficeSmartArtNode sustainProcess = segmentedProcessSmartArt.Nodes[2];
            sustainProcess.TextBody.Text = "Sustain";
            sustainProcess.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            AddSmartArtChildNode(sustainProcess, "Maintain healthy habits consistently.", "Set goals for continuous improvement.", 12f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "StepUp Process" layout
            WSmartArt stepUpProcessSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.StepUpProcess, 432, 252);

            // Add the "Start" phase node
            IOfficeSmartArtNode startNode = stepUpProcessSmartArt.Nodes[0];
            startNode.TextBody.Text = "Start";
            startNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            startNode.ChildNodes.Add();
            startNode.ChildNodes.Add();
            AddSmartArtChildNode(startNode, "Begin exercise and eat balanced meals.", "Stay hydrated and prioritize sleep.", 13f);

            // Add the "Track" phase node
            IOfficeSmartArtNode trackNode = stepUpProcessSmartArt.Nodes[1];
            trackNode.TextBody.Text = "Track";
            trackNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            trackNode.ChildNodes.Add();
            trackNode.ChildNodes.Add();
            AddSmartArtChildNode(trackNode, "Record physical activity and food intake.", "Use a fitness app or journal.", 13f);

            // Add the "Sustain" phase node
            IOfficeSmartArtNode sustainNode = stepUpProcessSmartArt.Nodes[2];
            sustainNode.TextBody.Text = "Sustain";
            sustainNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 17f;
            sustainNode.ChildNodes.Add();
            sustainNode.ChildNodes.Add();
            AddSmartArtChildNode(sustainNode, "Maintain healthy habits consistently.", "Set goals for continuous improvement.", 13f);
        }

        /// <summary>
        /// Creates a Cycle SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateCycleSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Customer Service Cycle");
            textRange1.CharacterFormat.FontSize = 28f;
            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Block Cycle" layout
            WSmartArt blockCycleSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BlockCycle, 432, 252);

            // Add the "Inquiry" phase node
            IOfficeSmartArtNode inquiryNode = blockCycleSmartArt.Nodes[0];
            inquiryNode.TextBody.Text = "Inquiry";
            inquiryNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Response" phase node
            IOfficeSmartArtNode responseNode = blockCycleSmartArt.Nodes[1];
            responseNode.TextBody.Text = "Response";
            responseNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Resolution" phase node
            IOfficeSmartArtNode resolutionNode = blockCycleSmartArt.Nodes[2];
            resolutionNode.TextBody.Text = "Resolution";
            resolutionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Feedback" phase node
            IOfficeSmartArtNode feedBackNode = blockCycleSmartArt.Nodes[3];
            feedBackNode.TextBody.Text = "Feedback";
            feedBackNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            // Add the "Follow-up" phase node
            IOfficeSmartArtNode followupNode = blockCycleSmartArt.Nodes[4];
            followupNode.TextBody.Text = "Follow-up";
            followupNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Basic Cycle" layout
            WSmartArt basicCycleSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BasicCycle, 432, 252);

            // Add the "Inquiry" phase node
            IOfficeSmartArtNode inquiryCycleNode = basicCycleSmartArt.Nodes[0];
            inquiryCycleNode.TextBody.Text = "Inquiry";
            inquiryCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Response" phase node
            IOfficeSmartArtNode responseCycleNode = basicCycleSmartArt.Nodes[1];
            responseCycleNode.TextBody.Text = "Response";
            responseCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Resolution" phase node
            IOfficeSmartArtNode resolutionCycleNode = basicCycleSmartArt.Nodes[2];
            resolutionCycleNode.TextBody.Text = "Resolution";
            resolutionCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Feedback" phase node
            IOfficeSmartArtNode feedbackCycleNode = basicCycleSmartArt.Nodes[3];
            feedbackCycleNode.TextBody.Text = "Feedback";
            feedbackCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

            // Add the "Follow-up" phase node
            IOfficeSmartArtNode followupCycleNode = basicCycleSmartArt.Nodes[4];
            followupCycleNode.TextBody.Text = "Follow-up";
            followupCycleNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 11f;

        }

        /// <summary>
        /// Creates a Hierarchy SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateHierarchySmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Company Organizational Structure");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Hierarchy" layout
            WSmartArt hierarchySmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.Hierarchy, 432, 252);

            // Configure the "Manager" node and its hierarchy
            IOfficeSmartArtNode manager = hierarchySmartArt.Nodes[0];
            manager.TextBody.Text = "Manager";
            manager.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].TextBody.Text = "Team Lead 1";
            manager.ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].ChildNodes[0].TextBody.Text = "Employee 1";
            manager.ChildNodes[0].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[0].ChildNodes[1].TextBody.Text = "Employee 2";
            manager.ChildNodes[0].ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[1].TextBody.Text = "Team Lead 2";
            manager.ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
            manager.ChildNodes[1].ChildNodes[0].TextBody.Text = "Employee 3";
            manager.ChildNodes[1].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Horizontal Hierarchy" layout
            WSmartArt horizontalHierarchySmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.HorizontalHierarchy, 432, 252);
            // Configure the "Manager" node and its hierarchy
            IOfficeSmartArtNode horizontalHierarchy = horizontalHierarchySmartArt.Nodes[0];
            horizontalHierarchy.TextBody.Text = "Manager";
            horizontalHierarchy.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].TextBody.Text = "Team Lead 1";
            horizontalHierarchy.ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].ChildNodes[0].TextBody.Text = "Employee 1";
            horizontalHierarchy.ChildNodes[0].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[0].ChildNodes[1].TextBody.Text = "Employee 2";
            horizontalHierarchy.ChildNodes[0].ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[1].TextBody.Text = "Team Lead 2";
            horizontalHierarchy.ChildNodes[1].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
            horizontalHierarchy.ChildNodes[1].ChildNodes[0].TextBody.Text = "Employee 3";
            horizontalHierarchy.ChildNodes[1].ChildNodes[0].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 24f;
        }

        /// <summary>
        /// Creates a Relationship SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateRelationshipSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Remote Work vs Office Work");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Counter Balance Arrows" layout
            WSmartArt counterBalanceArrowsSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.CounterBalanceArrows, 432, 252);
            // Add the "Remote Work" phase node
            IOfficeSmartArtNode remoteWorkNode = counterBalanceArrowsSmartArt.Nodes[0];
            remoteWorkNode.TextBody.Text = "Remote Work";
            remoteWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 19f;
            remoteWorkNode.ChildNodes.Add();
            remoteWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(remoteWorkNode, "Flexibility", "Work-Life Balance", 15f);

            // Add the "Office Work" phase node
            IOfficeSmartArtNode officeWorkNode = counterBalanceArrowsSmartArt.Nodes[1];
            officeWorkNode.TextBody.Text = "Office Work";
            officeWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 19f;
            officeWorkNode.ChildNodes.Add();
            officeWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(officeWorkNode, "Collaboration", "Structured Environment", 15f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Opposing Ideas" layout
            WSmartArt opposingIdeasSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.OpposingIdeas, 432, 252);

            // Add the "Remote Work" phase node
            remoteWorkNode = opposingIdeasSmartArt.Nodes[0];
            remoteWorkNode.TextBody.Text = "Remote Work";
            remoteWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            remoteWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(remoteWorkNode, "Flexibility", "Work-Life Balance", 20f);

            // Add the "Office Work" phase node
            officeWorkNode = opposingIdeasSmartArt.Nodes[1];
            officeWorkNode.TextBody.Text = "Office Work";
            officeWorkNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 15f;
            officeWorkNode.ChildNodes.Add();
            AddSmartArtChildNode(officeWorkNode, "Collaboration", "Structured Environment", 20f);
        }

        /// <summary>
        /// Creates a Matrix SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreateMatrixSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Marketing Campaign Process");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Grid Matrix" layout
            WSmartArt gridMatrixSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.GridMatrix, 432, 252);

            // Add the "Planning" phase node
            IOfficeSmartArtNode planningNode = gridMatrixSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            planningNode.ChildNodes.Add();
            planningNode.ChildNodes.Add();
            AddSmartArtChildNode(planningNode, "Define goals and target audience.", "Identify key messaging and channels.", 10f);

            // Add the "Execution" phase node
            IOfficeSmartArtNode executionNode = gridMatrixSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            executionNode.ChildNodes.Add();
            executionNode.ChildNodes.Add();
            AddSmartArtChildNode(executionNode, "Create content and implement strategies.", "Launch campaigns across chosen platforms.", 10f);

            // Add the "Monitoring" phase node
            IOfficeSmartArtNode monitoringNode = gridMatrixSmartArt.Nodes[2];
            monitoringNode.TextBody.Text = "Monitoring";
            monitoringNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            monitoringNode.ChildNodes.Add();
            monitoringNode.ChildNodes.Add();
            AddSmartArtChildNode(monitoringNode, "Track performance and engagement.", "Collect data and identify trends.", 10f);

            // Add the "Optimization" phase node
            IOfficeSmartArtNode optimizingNode = gridMatrixSmartArt.Nodes[3];
            optimizingNode.TextBody.Text = "Optimization";
            optimizingNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 13f;
            optimizingNode.ChildNodes.Add();
            optimizingNode.ChildNodes.Add();
            AddSmartArtChildNode(optimizingNode, "Adjust strategies based on insights.", "Fine-tune campaigns for better results.", 10f);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Cycle Matrix" layout
            WSmartArt cycleMatrixSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.CycleMatrix, 432, 252);

            // Add the "Planning" phase node
            planningNode = cycleMatrixSmartArt.Nodes[0];
            planningNode.TextBody.Text = "Planning";
            planningNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            planningNode.ChildNodes.Add();
            AddSmartArtChildNode(planningNode, "Define goals and target audience.", "Identify key messaging and channels.", 8f);

            // Add the "Execution" phase node
            executionNode = cycleMatrixSmartArt.Nodes[1];
            executionNode.TextBody.Text = "Execution";
            executionNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            executionNode.ChildNodes.Add();
            AddSmartArtChildNode(executionNode, "Create content and implement strategies.", "Launch campaigns across chosen platforms.", 8f);

            // Add the "Monitoring" phase node
            monitoringNode = cycleMatrixSmartArt.Nodes[2];
            monitoringNode.TextBody.Text = "Monitoring";
            monitoringNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            monitoringNode.ChildNodes.Add();
            AddSmartArtChildNode(monitoringNode, "Track performance and engagement.", "Collect data and identify trends.", 8f);

            // Add the "Optimization" phase node
            optimizingNode = cycleMatrixSmartArt.Nodes[3];
            optimizingNode.TextBody.Text = "Optimization";
            optimizingNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 12f;
            optimizingNode.ChildNodes.Add();
            AddSmartArtChildNode(optimizingNode, "Adjust strategies based on insights.", "Fine-tune campaigns for better results.", 8f);

        }

        /// <summary>
        /// Creates a Pyramid SmartArt diagrams.
        /// </summary>
        /// <param name="document">The Word document where the SmartArt diagram will be added.</param>
        private void CreatePyramidSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            IWTextRange textRange1 = paragraph.AppendText("Personal Growth");
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Basic Pyramid" layout
            WSmartArt basicPyramidSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.BasicPyramid, 432, 252);

            // Add the "Achievement" phase node
            IOfficeSmartArtNode achievementNode = basicPyramidSmartArt.Nodes[0];
            achievementNode.TextBody.Text = "Achievement";
            achievementNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            // Add the "Skill Development" phase node
            IOfficeSmartArtNode SkilldevelopmentNode = basicPyramidSmartArt.Nodes[1];
            SkilldevelopmentNode.TextBody.Text = "Skill Development";
            SkilldevelopmentNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            // Add the "Self-Awareness" phase node
            IOfficeSmartArtNode selfAwarenessNode = basicPyramidSmartArt.Nodes[2];
            selfAwarenessNode.TextBody.Text = "Self-Awareness";
            selfAwarenessNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 26f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Pyramid List" layout
            WSmartArt pyramidListSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.PyramidList, 432, 252);

            // Add the "Self-Awareness" phase node
            selfAwarenessNode = pyramidListSmartArt.Nodes[0];
            selfAwarenessNode.TextBody.Text = "Self-Awareness";
            selfAwarenessNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            // Add the "Skill Development" phase node
            SkilldevelopmentNode = pyramidListSmartArt.Nodes[1];
            SkilldevelopmentNode.TextBody.Text = "Skill Development";
            SkilldevelopmentNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;

            // Add the "Achievement" phase node
            achievementNode = pyramidListSmartArt.Nodes[2];
            achievementNode.TextBody.Text = "Achievement";
            achievementNode.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 20f;
        }

        /// <summary>
        /// Creates a Picture SmartArt diagrams.
        /// </summary>
        private void CreatePictureSmartArt(WordDocument document)
        {
            IWSection section = document.Sections[0];

            // Retrieves the first paragraph and add text.
            IWParagraph paragraph = section.Paragraphs[0];
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
            WTextRange textRange1 = paragraph.AppendText("Employee Report") as WTextRange;
            textRange1.CharacterFormat.FontSize = 28f;

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;

            // Add SmartArt with "Picture Strips" layout
            WSmartArt pictureStripsSmartArt = paragraph.AppendSmartArt(OfficeSmartArtType.PictureStrips, 432, 252);

            // Add the "Employee1" phase node
            IOfficeSmartArtNode employeeNode1 = pictureStripsSmartArt.Nodes[0];
            employeeNode1.TextBody.Text = "Nancy Davolio";
            employeeNode1.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode1, fileDataValue["nancy-davolio.png"]);

            // Add the "Employee2" phase node
            IOfficeSmartArtNode employeeNode2 = pictureStripsSmartArt.Nodes[1];
            employeeNode2.TextBody.Text = "Andrew Fuller";
            employeeNode2.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode2, fileDataValue["andrew-fuller.png"]);

            // Add the "Employee3" phase node
            IOfficeSmartArtNode employeeNode3 = pictureStripsSmartArt.Nodes[2];
            employeeNode3.TextBody.Text = "Janet Leverling";
            employeeNode3.TextBody.Paragraphs[0].TextParts[0].Font.FontSize = 25f;
            AddPicture(employeeNode3, fileDataValue["janet-leverling.png"]);
        }

        /// <summary>
        /// Adds two child nodes to a given SmartArt node and applies formatting.
        /// </summary>
        /// <param name="node">The SmartArt node to which child nodes will be added.</param>
        /// <param name="childText1">Text content for the first child node.</param>
        /// <param name="childText2">Text content for the second child node.</param>
        /// <param name="fontSize">Font size to be applied to the child nodes.</param>
        private void AddSmartArtChildNode(IOfficeSmartArtNode node, string childText1, string childText2, float fontSize)
        {
            node.ChildNodes[0].TextBody.Text = childText1;
            node.ChildNodes[1].TextBody.Text = childText2;
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                node.ChildNodes[i].TextBody.Paragraphs[0].TextParts[0].Font.FontSize = fontSize;
            }
        }

        /// <summary>
        /// Loads an image from the specified file path and assigns it to the given SmartArt node.
        /// </summary>
        /// <param name="node">The SmartArt node where the image will be applied.</param>
        /// <param name="memoryStream">The memory stream of the image to be assigned.</param>
        private void AddPicture(IOfficeSmartArtNode node, MemoryStream memoryStream)
        {
            //Convert the memory stream into a byte array
            byte[] picByte = memoryStream.ToArray();
            node.Shapes[1].Fill.FillType = OfficeShapeFillType.Picture;
            node.Shapes[1].Fill.PictureFill.ImageBytes = picByte;
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
            
        }
        #endregion
    }
}
