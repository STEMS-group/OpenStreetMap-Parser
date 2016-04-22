# OpenStreetMap Parser

This program is capable of converting a OSM XML file into a CSV file.

## Format of the files

#### Nodes file
**Description**: it contains information regarding the nodes of the map
**File content**: node_id;latitude_in_degrees;longitude_in_degrees;longitude_in_radians;latitude_in_radians

#### Roads file
**Description**: it contains information regarding the roads
**File content**: road_id;road_name;is_two_way

#### Subroads file
**Description**: it contains information regarding the set of nodes that define a road
**File content**: road_id;node1_id;node2_id;
