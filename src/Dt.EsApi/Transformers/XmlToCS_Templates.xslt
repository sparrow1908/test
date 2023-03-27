<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output encoding="utf-8" omit-xml-declaration="yes" indent="no" method="text" />

  <!-- All used fields of value types must be nullable if the field is not required -->
  <xsl:template name="nullable">
    <xsl:param name="mandatory" />
    <xsl:param name="type" />
    <xsl:choose>
      <xsl:when test="$mandatory='false'">?</xsl:when>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="operatorsEqNotEq"><xsl:param name="typeName" />
        public static bool operator ==(<xsl:value-of select="@name" />? left, <xsl:value-of select="@name" />? right) => left?.Equals(right) ?? right is null;

        public static bool operator !=(<xsl:value-of select="@name" />? left, <xsl:value-of select="@name" />? right) => !(left == right);</xsl:template>
</xsl:stylesheet>