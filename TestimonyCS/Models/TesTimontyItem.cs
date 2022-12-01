
namespace TestimonyCS.Models
{
    //classes for the StreamReader converstion
    public class Rootobject
    {
        public string title { get; set; }
        public string tag { get; set; }
        public string url { get; set; }
        public string infoText { get; set; }
        public bool isTestimonies { get; set; }
        public Transcriptstr[] transcriptSTR { get; set; }
        public object transcriptDOC { get; set; }
        public object moreInfo { get; set; }
        public object images { get; set; }
        public Resource[] resources { get; set; }
    }

    public class Transcriptstr
    {
        public string transcript { get; set; }
        public string fromTime { get; set; }
        public string toTime { get; set; }
        public string subTitle { get; set; }
        public string fromSecond { get; set; }
    }

    public class Resource
    {
        public string title { get; set; }
        public object url { get; set; }
        public object urlTitle { get; set; }
        public string type { get; set; }
        public object elements { get; set; }
    }

}