<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <style>
        table {
        font-size: 15px;
        border-collapse: collapse;
        }
        th {
        padding: 5px;
        text-align: center;
        bgcolor:"purple";
        border: 1px solid gray;
        }
        td {
        padding: 5px;
        border: 1px solid gray;
        }
      </style>
      <body>
        <h1>Albums</h1>
        <table>
          <tr bgcolor="purple" style="color:white">
            <th>Album</th>
            <th>Artist</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
          </tr>
          <xsl:for-each select="catalogue/album">
            <xsl:variable name="bgclr">
              <xsl:choose>
                <xsl:when test="position() mod 2 = 0">#EDF2F8</xsl:when>
                <xsl:otherwise>#FFFFFF</xsl:otherwise>
              </xsl:choose>
            </xsl:variable>
            <tr bgcolor="{$bgclr}">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>              
              <td>
                <xsl:for-each select="songs/song">
                  <div>
                    title:<xsl:value-of select="title"/>/
                    duration:<xsl:value-of select="duration"/>
                  </div>
                </xsl:for-each>
              </td>              
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
