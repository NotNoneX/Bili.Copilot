﻿// Copyright (c) Rodel. All rights reserved.
// <auto-generated />

using Markdig.Syntax;
using BiliCopilot.UI.Controls.Markdown.TextElements;

namespace BiliCopilot.UI.Controls.Markdown.Renderers.ObjectRenderers;

internal class CodeBlockRenderer : WinUIObjectRenderer<CodeBlock>
{
    protected override void Write(WinUIRenderer renderer, CodeBlock obj)
    {
        var code = new MyCodeBlock(obj, renderer.Config);
        renderer.Push(code);
        renderer.Pop();
    }
}
