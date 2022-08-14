<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/20 15:38:17">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="2">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="5">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 38 2.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="0 40 2.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="119">
                    <Brush id="0" owner="0" type="0" pos="-2.5 2.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 2.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.5 0.5" />
                            <Vertex pos="5.5 0.5 0" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 0" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                            <Vertex pos="-0.5 -5.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-2.5 8.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 8.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 0" />
                            <Vertex pos="5.5 -3.5 -0.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="-0.5 -3.5 0" />
                            <Vertex pos="-0.5 -3.5 -0.5" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                            <Vertex pos="-0.5 -5.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 0.848875" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -1.33395" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-2.5 10.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 10.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -1.5 -2" />
                            <Vertex pos="5.5 -1.5 -2.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="5.5 -5.5 -0.5" />
                            <Vertex pos="-0.5 -1.5 -2" />
                            <Vertex pos="-0.5 -1.5 -2.5" />
                            <Vertex pos="-0.5 -5.5 0" />
                            <Vertex pos="-0.5 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-2.5 14.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 14.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 -2.5" />
                            <Vertex pos="5.5 -3.5 -3" />
                            <Vertex pos="5.5 -5.5 -2" />
                            <Vertex pos="5.5 -5.5 -2.5" />
                            <Vertex pos="-0.5 -3.5 -2.5" />
                            <Vertex pos="-0.5 -3.5 -3" />
                            <Vertex pos="-0.5 -5.5 -2" />
                            <Vertex pos="-0.5 -5.5 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 3.27423" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 -3.7593" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-2.5 16.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 16.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 12.5 0.5" />
                            <Vertex pos="5.5 12.5 -17.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 12.5 0.5" />
                            <Vertex pos="-0.5 12.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-2.5 34.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 34.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 1.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 1.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 1.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 1.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="1.5 34.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 34.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 1.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 1.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 1.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 1.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-0.5 34.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 34.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 2.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 2.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 2.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 2.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-2.5 36.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 36.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 4.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 4.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 4.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="1.5 36.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 36.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 4.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 4.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 4.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-0.5 36.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 36.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 3.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 3.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 3.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 3.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-2.5 38.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 38.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 5.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 5.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 5.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 5.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="1.5 38.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 38.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 5.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 5.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 5.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 5.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-0.5 38.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 38.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 -3.5 6.5" />
                            <Vertex pos="1.5 -3.5 -17.5" />
                            <Vertex pos="1.5 -5.5 6.5" />
                            <Vertex pos="1.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 6.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 6.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_tile06_C" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-2.5 40.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 40.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 6.5" />
                            <Vertex pos="5.5 -3.5 -17.5" />
                            <Vertex pos="5.5 -5.5 6.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 6.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 6.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-2.5 42.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 42.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 6.5" />
                            <Vertex pos="5.5 -3.5 -17.5" />
                            <Vertex pos="5.5 -5.5 6.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="3.5 -3.5 6.5" />
                            <Vertex pos="3.5 -3.5 -17.5" />
                            <Vertex pos="3.5 -5.5 6.5" />
                            <Vertex pos="3.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-2.5 44.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 44.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 6.5" />
                            <Vertex pos="5.5 -3.5 -17.5" />
                            <Vertex pos="5.5 -5.5 6.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 -3.5 6.5" />
                            <Vertex pos="-0.5 -3.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 6.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-4.5 42.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 42.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 0.5" />
                            <Vertex pos="5.5 -3.5 -17.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="3.5 -3.5 0.5" />
                            <Vertex pos="3.5 -3.5 -17.5" />
                            <Vertex pos="3.5 -5.5 0.5" />
                            <Vertex pos="3.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_bounce_high" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-6.5 42.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 42.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 0.5" />
                            <Vertex pos="5.5 -3.5 -17.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="3.5 -3.5 0.5" />
                            <Vertex pos="3.5 -3.5 -17.5" />
                            <Vertex pos="3.5 -5.5 0.5" />
                            <Vertex pos="3.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-6.5 42.5 5" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 42.5 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 -1.5" />
                            <Vertex pos="5.5 -3.5 -5.5" />
                            <Vertex pos="5.5 -5.5 -1.5" />
                            <Vertex pos="5.5 -5.5 -5.5" />
                            <Vertex pos="3.5 -3.5 -1.5" />
                            <Vertex pos="3.5 -3.5 -5.5" />
                            <Vertex pos="3.5 -5.5 -1.5" />
                            <Vertex pos="3.5 -5.5 -5.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="1" type="999" pos="-4.5 42.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -4.5 0 1 0 42.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 -3.5" />
                            <Vertex pos="5.5 -3.5 -5.5" />
                            <Vertex pos="5.5 -5.5 -3.5" />
                            <Vertex pos="5.5 -5.5 -5.5" />
                            <Vertex pos="3.5 -3.5 -3.5" />
                            <Vertex pos="3.5 -3.5 -5.5" />
                            <Vertex pos="3.5 -5.5 -3.5" />
                            <Vertex pos="3.5 -5.5 -5.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 3.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-8.5 22.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -8.5 0 1 0 22.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.5 0.5" />
                            <Vertex pos="5.5 0.5 0" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="3.5 0.5 0" />
                            <Vertex pos="3.5 0.5 -0.5" />
                            <Vertex pos="3.5 -5.5 0" />
                            <Vertex pos="3.5 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 0.848875" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -1.33395" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-10.5 22.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 22.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.5 0" />
                            <Vertex pos="5.5 0.5 -0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="5.5 -5.5 -0.5" />
                            <Vertex pos="3.5 0.5 -1" />
                            <Vertex pos="3.5 0.5 -1.5" />
                            <Vertex pos="3.5 -5.5 -1" />
                            <Vertex pos="3.5 -5.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 2.45967" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.90689" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-12.5 22.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -12.5 0 1 0 22.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.5 -1" />
                            <Vertex pos="5.5 0.5 -1.5" />
                            <Vertex pos="5.5 -5.5 -1" />
                            <Vertex pos="5.5 -5.5 -1.5" />
                            <Vertex pos="3.5 0.5 -1.5" />
                            <Vertex pos="3.5 0.5 -2" />
                            <Vertex pos="3.5 -5.5 -1.5" />
                            <Vertex pos="3.5 -5.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 2.30409" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -2.78916" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-14.5 22.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -14.5 0 1 0 22.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 6.5 -1.5" />
                            <Vertex pos="5.5 6.5 -2" />
                            <Vertex pos="5.5 -5.5 -1.5" />
                            <Vertex pos="5.5 -5.5 -2" />
                            <Vertex pos="-0.5 6.5 -1.5" />
                            <Vertex pos="-0.5 6.5 -2" />
                            <Vertex pos="-0.5 -5.5 -1.5" />
                            <Vertex pos="-0.5 -5.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-2.5 46.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 46.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 0.5 6.5" />
                            <Vertex pos="5.5 0.5 -17.5" />
                            <Vertex pos="5.5 -5.5 6.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 0.5 6.5" />
                            <Vertex pos="-0.5 0.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 6.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-2.5 52.5 3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 52.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 1" />
                            <Vertex pos="5.5 -3.5 0.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="-0.5 -3.5 1" />
                            <Vertex pos="-0.5 -3.5 0.5" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                            <Vertex pos="-0.5 -5.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -1.81902" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 1.33395" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-2.5 54.5 3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 54.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 2.5 5" />
                            <Vertex pos="5.5 2.5 4.5" />
                            <Vertex pos="5.5 -5.5 1" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="-0.5 2.5 5" />
                            <Vertex pos="-0.5 2.5 4.5" />
                            <Vertex pos="-0.5 -5.5 1" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -3.3541" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 2.90689" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-2.5 62.5 3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 62.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 5.5" />
                            <Vertex pos="5.5 -3.5 5" />
                            <Vertex pos="5.5 -5.5 5" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -3.5 5.5" />
                            <Vertex pos="-0.5 -3.5 5" />
                            <Vertex pos="-0.5 -5.5 5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -6.18466" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 5.69959" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-2.5 64.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 64.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 12.5 11.5" />
                            <Vertex pos="5.5 12.5 -17.5" />
                            <Vertex pos="5.5 -5.5 11.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 12.5 11.5" />
                            <Vertex pos="-0.5 12.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 11.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-2.5 82.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 82.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 5.5" />
                            <Vertex pos="5.5 -3.5 5" />
                            <Vertex pos="5.5 -5.5 5" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -3.5 5.5" />
                            <Vertex pos="-0.5 -3.5 5" />
                            <Vertex pos="-0.5 -5.5 5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970142 -6.18466" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 5.69959" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-2.5 84.5 4" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 84.5 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 6" />
                            <Vertex pos="5.5 -3.5 5.5" />
                            <Vertex pos="5.5 -5.5 5" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -3.5 6" />
                            <Vertex pos="-0.5 -3.5 5.5" />
                            <Vertex pos="-0.5 -5.5 5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -6.93181" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 6.4846" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-2.5 102.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 102.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 12.5 14.5" />
                            <Vertex pos="5.5 12.5 -17.5" />
                            <Vertex pos="5.5 -5.5 14.5" />
                            <Vertex pos="5.5 -5.5 -17.5" />
                            <Vertex pos="-0.5 12.5 14.5" />
                            <Vertex pos="-0.5 12.5 -17.5" />
                            <Vertex pos="-0.5 -5.5 14.5" />
                            <Vertex pos="-0.5 -5.5 -17.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-2.5 120.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 120.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 4.5" />
                            <Vertex pos="5.5 -3.5 4" />
                            <Vertex pos="5.5 -5.5 5" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -3.5 4.5" />
                            <Vertex pos="-0.5 -3.5 4" />
                            <Vertex pos="-0.5 -5.5 5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -3.51677" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 3.0317" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-2.5 122.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 122.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 3.5" />
                            <Vertex pos="5.5 -3.5 3" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="5.5 -5.5 4" />
                            <Vertex pos="-0.5 -3.5 3.5" />
                            <Vertex pos="-0.5 -3.5 3" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -5.5 4" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -1.56525" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 1.11803" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-2.5 124.5 6.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 124.5 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 3" />
                            <Vertex pos="5.5 -3.5 2.5" />
                            <Vertex pos="5.5 -5.5 3.5" />
                            <Vertex pos="5.5 -5.5 3" />
                            <Vertex pos="-0.5 -3.5 3" />
                            <Vertex pos="-0.5 -3.5 2.5" />
                            <Vertex pos="-0.5 -5.5 3.5" />
                            <Vertex pos="-0.5 -5.5 3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -2.06155" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 1.57648" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-2.5 126.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 126.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 6.5 0.5" />
                            <Vertex pos="5.5 6.5 0" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 0" />
                            <Vertex pos="-0.5 6.5 0.5" />
                            <Vertex pos="-0.5 6.5 0" />
                            <Vertex pos="-0.5 -5.5 0.5" />
                            <Vertex pos="-0.5 -5.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-2.5 126.5 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 126.5 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 6.5 0.5" />
                            <Vertex pos="5.5 6.5 0" />
                            <Vertex pos="5.5 0.5 0.5" />
                            <Vertex pos="5.5 0.5 0" />
                            <Vertex pos="-0.5 6.5 0.5" />
                            <Vertex pos="-0.5 6.5 0" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-2.5 126.5 13" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 126.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 4.5" />
                            <Vertex pos="5.5 -3.5 4" />
                            <Vertex pos="5.5 -5.5 5" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -3.5 4.5" />
                            <Vertex pos="-0.5 -3.5 4" />
                            <Vertex pos="-0.5 -5.5 5" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -3.51677" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 3.0317" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-2.5 128.5 13" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 128.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 3.5" />
                            <Vertex pos="5.5 -3.5 3" />
                            <Vertex pos="5.5 -5.5 4.5" />
                            <Vertex pos="5.5 -5.5 4" />
                            <Vertex pos="-0.5 -3.5 3.5" />
                            <Vertex pos="-0.5 -3.5 3" />
                            <Vertex pos="-0.5 -5.5 4.5" />
                            <Vertex pos="-0.5 -5.5 4" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -1.56525" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 1.11803" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-2.5 130.5 13" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 130.5 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 3" />
                            <Vertex pos="5.5 -3.5 2.5" />
                            <Vertex pos="5.5 -5.5 3.5" />
                            <Vertex pos="5.5 -5.5 3" />
                            <Vertex pos="-0.5 -3.5 3" />
                            <Vertex pos="-0.5 -3.5 2.5" />
                            <Vertex pos="-0.5 -5.5 3.5" />
                            <Vertex pos="-0.5 -5.5 3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -2.06155" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970142 1.57648" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-2.5 114.5 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 114.5 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 6.5 0.5" />
                            <Vertex pos="5.5 6.5 0" />
                            <Vertex pos="5.5 0.5 0.5" />
                            <Vertex pos="5.5 0.5 0" />
                            <Vertex pos="-0.5 6.5 0.5" />
                            <Vertex pos="-0.5 6.5 0" />
                            <Vertex pos="-0.5 0.5 0.5" />
                            <Vertex pos="-0.5 0.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="3 2.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 2.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-3.5 2.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 2.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-3.5 -3.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -3.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0" />
                            <Vertex pos="7 0.5 -0.5" />
                            <Vertex pos="7 0 0" />
                            <Vertex pos="7 0 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 0 0" />
                            <Vertex pos="0 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="3 8.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 8.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-3.5 8.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 8.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="3 10.5 0" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 10.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1.5 -2" />
                            <Vertex pos="0.5 -1.5 -2.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -1.5 -2" />
                            <Vertex pos="0 -1.5 -2.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 512 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-3.5 10.5 0" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 10.5 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -1.5 -2" />
                            <Vertex pos="0.5 -1.5 -2.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -1.5 -2" />
                            <Vertex pos="0 -1.5 -2.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="3 14.5 -2" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 14.5 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-3.5 14.5 -2" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 14.5 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="3 16.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 16.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-3.5 16.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 16.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0 0" />
                            <Vertex pos="0.5 0 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 0 0" />
                            <Vertex pos="0 0 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-3.5 29 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 29 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0 0" />
                            <Vertex pos="0.5 0 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 0 0" />
                            <Vertex pos="0 0 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-3.5 34.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 34.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0.5" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0.5" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -5 0.5" />
                            <Vertex pos="0 -5 -0.5" />
                            <Vertex pos="0 -5.5 0.5" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-3.5 36.5 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 36.5 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 -0.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-3.5 38.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 38.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 1.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 1.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 1.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-3.5 40.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 40.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 1.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 1.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 1.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-3.5 34.5 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 34.5 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-3.5 36.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 36.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-3.5 38.5 2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 38.5 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-3.5 40.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 40.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="3 34.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 34.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0.5" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0.5" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -5 0.5" />
                            <Vertex pos="0 -5 -0.5" />
                            <Vertex pos="0 -5.5 0.5" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="3 36.5 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 36.5 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 -0.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="3 38.5 -0.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 38.5 0 0 1 -0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 1.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 1.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 1.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="3 40.5 0.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 40.5 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 2.5" />
                            <Vertex pos="0.5 -5 1.5" />
                            <Vertex pos="0.5 -5.5 2.5" />
                            <Vertex pos="0.5 -5.5 1.5" />
                            <Vertex pos="0 -5 2.5" />
                            <Vertex pos="0 -5 1.5" />
                            <Vertex pos="0 -5.5 2.5" />
                            <Vertex pos="0 -5.5 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 1.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="3 34.5 -1.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 34.5 0 0 1 -1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="3 36.5 1.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 36.5 0 0 1 1.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="3 38.5 2.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 38.5 0 0 1 2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="3 40.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 40.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-3.5 28.5 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 28.5 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -256 0.25 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.121268" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.606339" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-3.5 22 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 22 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0.25 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.121268" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.606339" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-7.5 28.5 -4" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 28.5 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -256 0.25 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.121268" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.606339" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-7.5 22 -4" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 22 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0.25 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 0.121268" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.606339" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-5.5 28.5 -3" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 28.5 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5 -1.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                            <Vertex pos="-1.5 -5.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -256 0.5 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.67082" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-5.5 22 -3" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 22 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -5 0" />
                            <Vertex pos="0.5 -5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="-1.5 -5 -1" />
                            <Vertex pos="-1.5 -5 -1.5" />
                            <Vertex pos="-1.5 -5.5 -1" />
                            <Vertex pos="-1.5 -5.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0.5 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.67082" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-16 16.5 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 16.5 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0" />
                            <Vertex pos="7 0.5 -0.5" />
                            <Vertex pos="7 0 0" />
                            <Vertex pos="7 0 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0.5 0 0" />
                            <Vertex pos="0.5 0 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-15.5 22.5 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.5 0 1 0 22.5 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-9 29 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 29 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0 0" />
                            <Vertex pos="0.5 0 -0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 0 0" />
                            <Vertex pos="0 0 -0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="3 52.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 52.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-3.5 52.5 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 52.5 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="3 62.5 8" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 62.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-3.5 62.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 62.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="3 60.5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 60.5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -11.5 -3.5" />
                            <Vertex pos="0.5 -11.5 -4" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -11.5 -3.5" />
                            <Vertex pos="0 -11.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0.5 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.01246" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 1.56525" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-3.5 60.5 7.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 60.5 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -11.5 -3.5" />
                            <Vertex pos="0.5 -11.5 -4" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -11.5 -3.5" />
                            <Vertex pos="0 -11.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2816 0 0.5 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -11.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.01246" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 1.56525" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="3 58.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 58.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="3 70.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 70.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-3.5 58.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 58.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 18.5 0" />
                            <Vertex pos="0.5 18.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 18.5 0" />
                            <Vertex pos="0 18.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -18.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="3 82.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 82.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-3.5 82.5 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 82.5 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -3.5 0" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -3.5 0" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 0.25 -1 352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 0.848875" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="3 84.5 9" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 84.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 1" />
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 1" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0.5 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 2.01246" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-3.5 84.5 9" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 84.5 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 1" />
                            <Vertex pos="0.5 -3.5 0.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 1" />
                            <Vertex pos="0 -3.5 0.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 0.5 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 2.01246" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="3 96.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 96.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 18.5 0" />
                            <Vertex pos="0.5 18.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 18.5 0" />
                            <Vertex pos="0 18.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -18.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-3.5 96.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 96.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 18.5 0" />
                            <Vertex pos="0.5 18.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 18.5 0" />
                            <Vertex pos="0 18.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -18.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="3 120.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 120.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-3.5 120.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 120.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="3 124.5 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 124.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-3.5 124.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 124.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="3 122.5 11" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 122.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -3.5 -1.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -3.5 -1.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-3.5 122.5 11" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 122.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -3.5 -1.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -3.5 -1.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="3 126.5 18" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 126.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-3.5 126.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 126.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="3 130.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 130.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-3.5 130.5 16.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 130.5 0 0 1 16.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -0.5" />
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.33395" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.81902" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="3 128.5 17.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 128.5 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -3.5 -1.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -3.5 -1.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-3.5 128.5 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 128.5 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 -3.5 -1" />
                            <Vertex pos="0.5 -3.5 -1.5" />
                            <Vertex pos="0.5 -5.5 0" />
                            <Vertex pos="0.5 -5.5 -0.5" />
                            <Vertex pos="0 -3.5 -1" />
                            <Vertex pos="0 -3.5 -1.5" />
                            <Vertex pos="0 -5.5 0" />
                            <Vertex pos="0 -5.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.5 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.45967" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.90689" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="3 120.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 120.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-3.5 120.5 9.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 120.5 0 0 1 9.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 0.5 0" />
                            <Vertex pos="0.5 0.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="3 120.5 16" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 120.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 6.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-3.5 120.5 16" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 120.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 6.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="3 108.5 18" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 108.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 6.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-3.5 108.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 108.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 6.5 0" />
                            <Vertex pos="0.5 6.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 6.5 0" />
                            <Vertex pos="0 6.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 6.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-3.5 114.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 114.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0" />
                            <Vertex pos="7 0.5 -0.5" />
                            <Vertex pos="7 0.25 0" />
                            <Vertex pos="7 0.25 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 0.25 0" />
                            <Vertex pos="0 0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_trim" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_trim" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-3.5 96.5 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 96.5 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0" />
                            <Vertex pos="7 0.5 -0.5" />
                            <Vertex pos="7 0.25 0" />
                            <Vertex pos="7 0.25 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 0.25 0" />
                            <Vertex pos="0 0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_trim" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_trim" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="4" type="4" pos="-6.5 42.5 -1" rot="1 0 0 0" scale="" transform="1 0 0 -6.5 0 1 0 42.5 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 -3.5 0.5" />
                            <Vertex pos="5.5 -3.5 -1.5" />
                            <Vertex pos="5.5 -5.5 0.5" />
                            <Vertex pos="5.5 -5.5 -1.5" />
                            <Vertex pos="3.5 -3.5 0.5" />
                            <Vertex pos="3.5 -3.5 -1.5" />
                            <Vertex pos="3.5 -5.5 0.5" />
                            <Vertex pos="3.5 -5.5 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 3.5" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile08_B" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-2.5 126.5 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 126.5 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.5 6.5 0.5" />
                            <Vertex pos="5.5 6.5 0" />
                            <Vertex pos="5.5 2.5 0.5" />
                            <Vertex pos="5.5 2.5 0" />
                            <Vertex pos="-0.5 6.5 0.5" />
                            <Vertex pos="-0.5 6.5 0" />
                            <Vertex pos="-0.5 2.5 0.5" />
                            <Vertex pos="-0.5 2.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -448 0 -1 0 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0" album="Blasted" material="bm_tile08_B" texgens="-1 0 0 384 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="3 120.5 18" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 120.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 8.5 0" />
                            <Vertex pos="0.5 8.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 8.5 0" />
                            <Vertex pos="0 8.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 8.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-3.5 120.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 120.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 12.5 0" />
                            <Vertex pos="0.5 12.5 -0.5" />
                            <Vertex pos="0.5 8.5 0" />
                            <Vertex pos="0.5 8.5 -0.5" />
                            <Vertex pos="0 12.5 0" />
                            <Vertex pos="0 12.5 -0.5" />
                            <Vertex pos="0 8.5 0" />
                            <Vertex pos="0 8.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 8.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-3.5 128.5 18" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 128.5 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0" />
                            <Vertex pos="7 0.5 -0.5" />
                            <Vertex pos="7 0.25 0" />
                            <Vertex pos="7 0.25 -0.5" />
                            <Vertex pos="0 0.5 0" />
                            <Vertex pos="0 0.5 -0.5" />
                            <Vertex pos="0 0.25 0" />
                            <Vertex pos="0 0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_trim" texgens="0 1 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_trim" texgens="0 -1 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
