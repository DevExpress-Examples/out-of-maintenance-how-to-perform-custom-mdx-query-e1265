# How to perform custom MDX query


<p>This example shows how to make a custom mdx query and display its results in the XtraPivotGrid. With a little customization, this example can be used for the ASPxPivotGrid. This example uses the OLAP "Adventure Works DW Standard Edition" sample. It can be found in the C:\Program Files\Microsoft SQL Server\90\Tools\Samples\AdventureWorks Analysis Services Project\Standard\ folder.<br />
We've created an OleDbCommand to query the OLAP server. The MDX query for this command should have the following structure: </p><p>select<br />
{ <measures> } on columns,<br />
{ <column and row fields> } on rows<br />
from <cube name></p><p>This query will produce a tabular result that is ok for the XtraPivotGrid. Here is a sample:<br />
[Sales Territory].[Sales Territory Group].[Sales Territory Group].[MEMBER_CAPTION], [Sales Territory].[Sales Territory Country].[Sales Territory Country].[MEMBER_CAPTION], [Measures].[Internet Sales Amount]<br />
Europe     France     $2,644,017.71<br />
Europe     Germany     $2,894,312.34<br />
Europe     United Kingdom     $3,391,712.21</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2299">How to generate an MDX query automatically according to the current pivot grid layout</a></p>

<br/>


