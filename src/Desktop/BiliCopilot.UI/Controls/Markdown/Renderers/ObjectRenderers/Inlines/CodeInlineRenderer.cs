﻿// Copyright (c) Rodel. All rights reserved.
// <auto-generated />

using Markdig.Syntax.Inlines;
using BiliCopilot.UI.Controls.Markdown.TextElements;

namespace BiliCopilot.UI.Controls.Markdown.Renderers.ObjectRenderers.Inlines;

internal class CodeInlineRenderer : WinUIObjectRenderer<CodeInline>
{
    protected override void Write(WinUIRenderer renderer, CodeInline obj)
    {
        if (renderer == null)
        {
            throw new ArgumentNullException(nameof(renderer));
        }

        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj));
        }

        renderer.WriteInline(new MyInlineCode(obj, renderer.Config));
    }
}
