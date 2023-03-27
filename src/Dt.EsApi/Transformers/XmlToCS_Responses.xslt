<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:param name="output_file_type">cs</xsl:param>
  <xsl:param name="filename" />
  <xsl:param name="transformername" />

  <xsl:include href="XmlToCS_templates.xslt" />
  <xsl:output encoding="utf-8" />

<xsl:template match="/">
  ////////////////////////////////////////////////
  ////             GENERATED FILE             ////
  ////////////////////////////////////////////////

// Generated code from "<xsl:value-of select="$filename"/>"
// By using transformation "<xsl:value-of select="$transformername"/>"

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Dt.EsApi.Contract;
using ServerLogic.Types;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable ClassNeverInstantiated.Global

#nullable enable
<xsl:apply-templates/>
</xsl:template>
<xsl:template match="namespace">
<xsl:text>namespace </xsl:text>
<xsl:value-of select="@name"/>
{<xsl:apply-templates/>}
</xsl:template>

<xsl:template match="struct">[GeneratedCode("xslt-proc", "undefined")]
    public class <xsl:value-of select="@name"/> : ActionResponse
    {
<xsl:for-each select="field">
        public <xsl:value-of select="@type"/>
        <xsl:call-template name="nullable">
        <xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param>
        <xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
        </xsl:call-template>
        <xsl:text xml:space="preserve"> </xsl:text>
        <xsl:value-of select="@name"/>
        <xsl:text> { get; init; }</xsl:text>
</xsl:for-each>

<xsl:for-each select="collection_field">
        public <xsl:value-of select="@type"/>&lt;<xsl:value-of select="@internal_type"/><xsl:text>&gt;</xsl:text>
        <xsl:call-template name="nullable">
          <xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param>
          <xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
        </xsl:call-template>
        <xsl:text xml:space="preserve"> </xsl:text>
        <xsl:value-of select="@name"/>
        <xsl:text> { get; init; }</xsl:text>
</xsl:for-each>
    }
</xsl:template>
</xsl:stylesheet>