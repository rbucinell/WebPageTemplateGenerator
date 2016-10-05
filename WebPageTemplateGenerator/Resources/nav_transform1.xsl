<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
  
	<xsl:for-each select="navigation/item">
		
		<xsl:element name="li">
			<xsl:attribute name="class">navitem</xsl:attribute>
			
			<xsl:element name="a">
				<xsl:attribute name="href">#</xsl:attribute>
				
				<xsl:element name="div">
					<xsl:attribute name="class">text</xsl:attribute>					
					<xsl:value-of select="@name" />
				</xsl:element><!--end the div showing menu category-->				
			</xsl:element><!--end anchor linking category -->
			
			
			<xsl:if test="subitem">		
				<xsl:element name="ul">
						<xsl:attribute name="class">subnav</xsl:attribute>
					
					
					<xsl:for-each select="subitem">
						<!--build the sub item -->
						<xsl:element name="li">
							<xsl:attribute name="class">linkitem</xsl:attribute>
							
							<xsl:element name="a">
							
								<xsl:attribute name="href">
									<xsl:value-of select="@target" />
								</xsl:attribute>
								
								<xsl:if test="@external">
									<xsl:attribute name="target">_blank</xsl:attribute>
								</xsl:if>
							
								<xsl:element name="div">
									<xsl:attribute name="class">text</xsl:attribute>
										<xsl:value-of select="@name" />
								</xsl:element><!--end the div showing menu item-->
								
							</xsl:element><!--end anchor linking item -->	
							
						</xsl:element>					
					</xsl:for-each><!--end each sub item iteration-->
					
					
					
				</xsl:element> <!--end subnav list -->
			</xsl:if>
			
			
		</xsl:element><!-- end li -->
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
