﻿namespace BlazorRepl.Client.Components
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BlazorRepl.Core;
    using Microsoft.AspNetCore.Components;
    using Microsoft.CodeAnalysis;

    public partial class ErrorList
    {
        [Parameter]
        public IReadOnlyCollection<CompilationDiagnostic> Diagnostics { get; set; } = Array.Empty<CompilationDiagnostic>();

        [Parameter]
        public bool Show { get; set; }

        [Parameter]
        public EventCallback<bool> ShowChanged { get; set; }

        private Task ToggleDiagnosticsAsync()
        {
            this.Show = !this.Show;
            return this.ShowChanged.InvokeAsync(this.Show);
        }
    }
}
