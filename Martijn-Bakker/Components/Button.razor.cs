﻿using Microsoft.AspNetCore.Components;

namespace Martijn_Bakker.Components
{
    public partial class Button
    {
        [Parameter]
        public string? Url { get; set; }

        [Parameter]
        public string? Target { get; set; }

        [Parameter]
        public string? Title { get; set; }

        [Parameter]
        public string? Text { get; set; }
    }
}
