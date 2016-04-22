# OpenStreetMap Parser

This program is capable of converting a OSM XML file into a CSV file.

## Format of the files

#### Nodes file
**Description**: it contains information regarding the nodes of the map.
**File content**: node\_id;latitude\_in\_degrees;longitude\_in\_degrees;longitude\_in\_radians;latitude\_in\_radians

#### Roads file
**Description**: it contains information regarding the roads.
**File content**: road\_id;road\_name;is\_two\_way

#### Subroads file
**Description**: it contains information regarding the set of nodes that define a road.
**File content**: road\_id;node1\_id;node2\_id;
