<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
                       xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output
		method="html"></xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border = "1">
					<TR>
						<th>Name</th>
						<th>CountryOfOrigin</th>
						<th>DebutY</th>
						<th>ArtType</th>
						<th>Style</th>
						<th>FamousWork</th>
						
					</TR>
					<xsl:for-each select = "Artists/Artist">
						<tr>
							<td>
								<xsl:value-of select = "@Name"/>
							</td>
							<td>
								<xsl:value-of select = "@CountryOfOrigin"/>
							</td>
							<td>
								<xsl:value-of select = "@DebutY"/>
							</td>
							<td>
								<xsl:value-of select = "@ArtType"/>
							</td>
							<td>
								<xsl:value-of select = "@Style"/>
							</td>							
							<td>
								<xsl:value-of select = "@FamousWork"/>
							</td>

						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
