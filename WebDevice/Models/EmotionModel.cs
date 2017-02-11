using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDevice.Models
{
    public class EmotionModel
    {
        public IEnumerable<Emotion> emotions { get; set; }
    }

    public class Emotion
    {
        public FaceRectangle faceRectangle { get; set; }
        public Sentiment scores { get; set; }
    }

    public class FaceRectangle
    {
        public string top { get; set; }
        public string left { get; set; }
        public string height { get; set; }
        public string width { get; set; }
    }

    public class Sentiment
    {
        public string anger { get; set; }
        public string contempt { get; set; }
        public string disgust { get; set; }
        public string fear { get; set; }
        public string happiness { get; set; }
        public string neutral { get; set; }
        public string sadness { get; set; }
        public string surprise { get; set; }
    }
}