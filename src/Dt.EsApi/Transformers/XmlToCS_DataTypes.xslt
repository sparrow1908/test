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
using System.ComponentModel;
using System.Linq;
using System.Text;
using Dt.EsApi;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable NonReadonlyMemberInGetHashCode

#nullable enable
<xsl:apply-templates/>
</xsl:template>
<xsl:template match="namespace">
<xsl:text>namespace </xsl:text>
<xsl:value-of select="@name"/>
{<xsl:apply-templates/>}
</xsl:template>

<xsl:template match="struct">
    <xsl:if test="@desc!=''">/// &lt;summary&gt; <xsl:value-of select="@desc"/> &lt;/summary&gt;</xsl:if>
    [GeneratedCode("xslt-proc", "undefined")]
    public class <xsl:value-of select="@name"/> : ICloneable&lt;<xsl:value-of select="@name"/>&gt;
    {
        #region Fields
<xsl:for-each select="field"><xsl:if test="@desc!=''">
        /// &lt;summary&gt; <xsl:value-of select="@desc"/> &lt;/summary&gt;
        [Description("<xsl:value-of select="@desc"/>")]</xsl:if>
        public <xsl:value-of select="@type"/>
        <xsl:call-template name="nullable">
        <xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param>
        <xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
        </xsl:call-template>
        <xsl:text xml:space="preserve"> </xsl:text>
        <xsl:value-of select="@name"/>
        <xsl:if test="@default!=''">=<xsl:value-of select="@default"/></xsl:if>
        <xsl:text>;</xsl:text>
</xsl:for-each>

<xsl:for-each select="collection_field">
        <xsl:if test="@desc!=''">
        /// &lt;summary&gt; <xsl:value-of select="@desc"/> &lt;/summary&gt;</xsl:if>
        public <xsl:value-of select="@type"/>&lt;<xsl:value-of select="@internal_type"/><xsl:text>&gt;</xsl:text>
        <xsl:call-template name="nullable">
          <xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param>
          <xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
        </xsl:call-template>
        <xsl:text xml:space="preserve"> </xsl:text>
        <xsl:value-of select="@name"/>
        <xsl:text>;</xsl:text>
</xsl:for-each>

        #endregion Fields

        #region ICloneable

        public <xsl:value-of select="@name"/> Clone()
        {
            var clone = new <xsl:value-of select="@name"/>();
<xsl:for-each select="field">
            clone.<xsl:value-of select="@name"/> = <xsl:value-of select="@name"/>;</xsl:for-each>

<xsl:for-each select="collection_field">
            clone.<xsl:value-of select="@name"/> = <xsl:value-of select="@name"/>?.<xsl:choose><xsl:when test="@internal_type='int'">ToList() ?? new();</xsl:when>
              <xsl:when test="@internal_type='string'">ToList() ?? new();</xsl:when>
              <xsl:when test="@internal_type='double'">ToList() ?? new();</xsl:when>
              <xsl:when test="@internal_type='DateTime'">ToList() ?? new();</xsl:when>
              <xsl:when test="@internal_type='bool'">ToList() ?? new();</xsl:when>
              <xsl:otherwise>Select(x => x.Clone()).ToList() ?? new();</xsl:otherwise>
            </xsl:choose>
</xsl:for-each>

            return clone;
        }

        #endregion ICloneable

        #region Equality

        public override int GetHashCode()
        {
            var hashCode = -659746988;<xsl:for-each select="collection_field">
            hashCode = hashCode * -1521134295 + CollectionEqualityComparer&lt;<xsl:value-of select="@internal_type"/>&gt;.Default.GetHashCode(<xsl:value-of select="@name"/>);</xsl:for-each><xsl:for-each select="field">
            hashCode = hashCode * -1521134295 + EqualityComparer&lt;<xsl:value-of select="@type"/><xsl:call-template name="nullable"><xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param><xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
        </xsl:call-template>&gt;.Default.GetHashCode(<xsl:value-of select="@name"/>);</xsl:for-each>
            return hashCode;
        }

        public override bool Equals(object? other)
        {
            return other is <xsl:value-of select="@name"/> casted &amp;&amp;<xsl:for-each select="collection_field">
                CollectionEqualityComparer&lt;<xsl:value-of select="@internal_type"/>&gt;.Default.Equals(<xsl:value-of select="@name"/>, casted.<xsl:value-of select="@name"/>)<xsl:if test="not (position()=last())"> &amp;&amp;</xsl:if></xsl:for-each><xsl:if test="count(field) = 0">;</xsl:if><xsl:if test="count(field) != 0"><xsl:if test="count(collection_field) != 0"> &amp;&amp;</xsl:if></xsl:if><xsl:for-each select="field">
                EqualityComparer&lt;<xsl:value-of select="@type"/><xsl:call-template name="nullable"><xsl:with-param name="mandatory"><xsl:value-of select="@mandatory"/></xsl:with-param><xsl:with-param name="type"><xsl:value-of select="@type"/></xsl:with-param>
                </xsl:call-template>&gt;.Default.Equals(<xsl:value-of select="@name"/>, casted.<xsl:value-of select="@name"/>)<xsl:if test="not (position() = last())"> &amp;&amp;</xsl:if><xsl:if test="position() = last()">;</xsl:if></xsl:for-each>
        }
<xsl:call-template name="operatorsEqNotEq"><xsl:with-param name="typeName"><xsl:value-of select="@name"/></xsl:with-param></xsl:call-template>

        #endregion Equality

        #region ToString

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            <xsl:for-each select="field">
            stringBuilder.AppendIfNotNull("<xsl:value-of select="@name"/>", <xsl:value-of select="@name"/>);</xsl:for-each>

            <xsl:for-each select="collection_field">
            stringBuilder.AppendIfNotNull("<xsl:value-of select="@name"/>", <xsl:value-of select="@name"/>);</xsl:for-each>

            return stringBuilder.ToString();
        }

        #endregion ToString
    }
</xsl:template>

<xsl:template match="enum">[GeneratedCode("xslt-proc", "undefined")]
    public enum <xsl:value-of select="@name"/>
    {
        <xsl:for-each select="item"><xsl:if test="@desc!=''">[Description("<xsl:value-of select="@desc"/>")]
        </xsl:if>
        <xsl:value-of select="@name"/> = <xsl:value-of select="@value"/><xsl:text>,
        </xsl:text></xsl:for-each>
    }
</xsl:template>
</xsl:stylesheet>