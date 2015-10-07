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
        <h1>Students Data</h1>
        <table>
          <tr bgcolor="purple" style="color:white">
            <th>Student</th>
            <th>Gender</th>
            <th>Birth Date</th>
            <th>Phone</th>
            <th>E-mail</th>
            <th>Course</th>
            <th>Specialty</th>
            <th>FacultyN</th>
            <th>Exams</th>
            <th>Enrollment</th>
            <th>Endorsement</th>
          </tr>
          <xsl:for-each select="students/student">
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
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birthDate"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="facultyNumber"/>
              </td>
              <td>
                <xsl:for-each select="exams/exam">
                  <div>
                    <xsl:value-of select="name"/>/
                    tutor:<xsl:value-of select="tutor"/>/
                    score:<xsl:value-of select="score"/>
                  </div>
                </xsl:for-each>
              </td>
              <td>
                <xsl:for-each select="enrollments/enrollment">
                  <div>
                    date:<xsl:value-of select="date"/>/
                    score:<xsl:value-of select="score"/>
                  </div>
                </xsl:for-each>
              </td>
              <td>
                <xsl:for-each select="teacher-endorsements">
                  <div>
                    teacher:<xsl:value-of select="teacher"/>/
                    endorsement:<xsl:value-of select="endorsement"/>
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
