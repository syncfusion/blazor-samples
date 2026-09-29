using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace BlazorDemos.Model
{
    public class ChatMessageModel : INotifyPropertyChanged
    {
        private string text = string.Empty;
        private DateTime timeStamp = DateTime.Now;
        private ChatMessageType messageType = ChatMessageType.Text;
        private ChartConfig? chartConfig;
        private string? imageBase64;

        public string Text
        {
            get => text;
            set { text = value; OnPropertyChanged(nameof(Text)); }
        }

        public DateTime TimeStamp
        {
            get => timeStamp;
            set { timeStamp = value; OnPropertyChanged(nameof(TimeStamp)); }
        }

        public ChatMessageType MessageType
        {
            get => messageType;
            set { messageType = value; OnPropertyChanged(nameof(MessageType)); }
        }

        public ChartConfig? ChartConfig
        {
            get => chartConfig;
            set { chartConfig = value; OnPropertyChanged(nameof(ChartConfig)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class ChatHistoryModel : INotifyPropertyChanged
    {
        private DateTime conversationCreatedDate;
        private ObservableCollection<ChatMessageModel> messages = new();
        private string title = string.Empty;

        public DateTime ConversationCreatedDate
        {
            get => conversationCreatedDate;
            set { conversationCreatedDate = value; OnPropertyChanged(nameof(ConversationCreatedDate)); }
        }

        public ObservableCollection<ChatMessageModel> Messages
        {
            get => messages;
            set { messages = value; OnPropertyChanged(nameof(Messages)); }
        }

        public string Message { get; set; } = string.Empty;

        public string Title
        {
            get => title;
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public enum ChatMessageType
    {
        Text,
        Chart
    }
}