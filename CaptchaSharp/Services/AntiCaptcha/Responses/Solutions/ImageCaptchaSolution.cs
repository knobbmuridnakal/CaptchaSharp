﻿using CaptchaSharp.Models;

namespace CaptchaSharp.Services.AntiCaptcha.Responses.Solutions
{
    internal class ImageCaptchaSolution : Solution
    {
        public string Text { get; set; }
        public string Url { get; set; }

        public override CaptchaResponse ToCaptchaResponse(long id)
        {
            return new StringResponse
            {
                Id = id,
                Response = Text
            };
        }
    }
}
