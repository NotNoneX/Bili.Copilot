﻿// Copyright (c) Rodel. All rights reserved.
// <auto-generated />

using Markdig.Syntax;
using Microsoft.UI.Xaml.Documents;

namespace BiliCopilot.UI.Controls.Markdown.TextElements;

internal class MyBlockContainer : IAddChild
{
    private readonly ContainerBlock _containerBlock;
    private InlineUIContainer _inlineUIContainer;
    private readonly MyFlowDocument _flowDocument;
    private Paragraph _paragraph;

    public TextElement TextElement => _paragraph;

    public MyBlockContainer(ContainerBlock containerBlock)
    {
        _containerBlock = containerBlock;
        _inlineUIContainer = new InlineUIContainer();
        _flowDocument = new MyFlowDocument(containerBlock);
        _inlineUIContainer.Child = _flowDocument.RichTextBlock;
        _paragraph = new Paragraph();
        _paragraph.Inlines.Add(_inlineUIContainer);
    }

    public void AddChild(IAddChild child) => _flowDocument.AddChild(child);
}
