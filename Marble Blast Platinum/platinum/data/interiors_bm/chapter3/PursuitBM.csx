<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/10/25 22:21:11">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="4">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="7" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="9">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="0" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-81 23.5 7" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-81 23.5 1" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-81 23.5 8" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-81 23.5 0" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="trigger" gametype="Torque" isPointEntity="0">
                        <Properties TargetTime="99999" datablock="TriggerGotoTarget" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="257">
                    <Brush id="0" owner="0" type="0" pos="0 3 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 3 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -0.00012207 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="3.25 3 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 3 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-3.25 3 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 3 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-14 -3 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -3 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-10.75 -3 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -3 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-17.25 -3 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -17.25 0 1 0 -3 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="0 -3.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-14 3.125 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 3.125 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.125 0.25" />
                            <Vertex pos="3.5 0.125 -0.25" />
                            <Vertex pos="3.5 -0.125 0.25" />
                            <Vertex pos="3.5 -0.125 -0.25" />
                            <Vertex pos="-3.5 0.125 0.25" />
                            <Vertex pos="-3.5 0.125 -0.25" />
                            <Vertex pos="-3.5 -0.125 0.25" />
                            <Vertex pos="-3.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_trim" texgens="0 1 0 -2912 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_trim" texgens="0 -1 0 3040 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -768 0 -1 0 3040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 896 0 -1 0 3040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-12 -10 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -10 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-16 -10 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -10 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-14 -13 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -13 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-16 -15 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -15 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-12 -18 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -18 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-1 3 0.25" />
                            <Vertex pos="-1 3 -0.25" />
                            <Vertex pos="-1 -3 0.25" />
                            <Vertex pos="-1 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-14 -18 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -18 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-16 -20 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -20 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 768 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-14 -24 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -24 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-10.75 -24 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -10.75 0 1 0 -24 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-17.25 -24 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -17.25 0 1 0 -24 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-16 -33 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -33 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 6 0.25" />
                            <Vertex pos="5 6 -0.25" />
                            <Vertex pos="0.999999 -6 0.25" />
                            <Vertex pos="0.999999 -6 -0.25" />
                            <Vertex pos="-0.999999 6 0.25" />
                            <Vertex pos="-0.999999 6 -0.25" />
                            <Vertex pos="-5 -6 0.25" />
                            <Vertex pos="-5 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0.316228 0 -2.84605" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0.316228 0 -2.84605" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-12.75 -33 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.75 0 1 0 -33 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 6 0.25" />
                            <Vertex pos="2.25 6 -0.25" />
                            <Vertex pos="-1.75 -6 0.25" />
                            <Vertex pos="-1.75 -6 -0.25" />
                            <Vertex pos="1.75 6 0.25" />
                            <Vertex pos="1.75 6 -0.25" />
                            <Vertex pos="-2.25 -6 0.25" />
                            <Vertex pos="-2.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0.316228 0 -0.237172" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0.316228 0 -0.237171" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 -0.333333 0 64.0005 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0.333333 0 64.0008 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-19.25 -33 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 -33 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 6 0.25" />
                            <Vertex pos="2.25 6 -0.25" />
                            <Vertex pos="-1.75 -6 0.25" />
                            <Vertex pos="-1.75 -6 -0.25" />
                            <Vertex pos="1.75 6 0.25" />
                            <Vertex pos="1.75 6 -0.25" />
                            <Vertex pos="-2.25 -6 0.25" />
                            <Vertex pos="-2.25 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0.316228 0 -0.237173" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0.316228 0 -0.237171" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 -0.333333 0 64.0005 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0.333333 0 64.001 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-18 -45 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -45 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-14.75 -44.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 -44.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5.75 0.25" />
                            <Vertex pos="0.25 5.75 -0.25" />
                            <Vertex pos="0.25 -5.75 0.25" />
                            <Vertex pos="0.25 -5.75 -0.25" />
                            <Vertex pos="-0.25 5.75 0.25" />
                            <Vertex pos="-0.25 5.75 -0.25" />
                            <Vertex pos="-0.25 -5.75 0.25" />
                            <Vertex pos="-0.25 -5.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5.75" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.75" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-21.25 -47.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -21.25 0 1 0 -47.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8.25 0.25" />
                            <Vertex pos="0.25 8.25 -0.25" />
                            <Vertex pos="0.25 -8.25 0.25" />
                            <Vertex pos="0.25 -8.25 -0.25" />
                            <Vertex pos="-0.25 8.25 0.25" />
                            <Vertex pos="-0.25 8.25 -0.25" />
                            <Vertex pos="-0.25 -8.25 0.25" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2112 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-14 -53 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -53 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 0.25" />
                            <Vertex pos="7 2 -0.25" />
                            <Vertex pos="7 -2 0.25" />
                            <Vertex pos="7 -2 -0.25" />
                            <Vertex pos="-7 2 0.25" />
                            <Vertex pos="-7 2 -0.25" />
                            <Vertex pos="-7 -2 0.25" />
                            <Vertex pos="-7 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1280 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="13 -53 4.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -53 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 -2 0.25" />
                            <Vertex pos="-4 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="23 -53 3.25" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -53 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 -0.75" />
                            <Vertex pos="6 2 -1.25" />
                            <Vertex pos="6 -2 -0.75" />
                            <Vertex pos="6 -2 -1.25" />
                            <Vertex pos="-6 2 1.25" />
                            <Vertex pos="-6 2 0.75" />
                            <Vertex pos="-6 -2 1.25" />
                            <Vertex pos="-6 -2 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -0.246598" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -0.246598" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="35 -53 2.25" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -53 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="38.5 -44 7.75" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -44 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 5 0.25" />
                            <Vertex pos="3 5 -0.25" />
                            <Vertex pos="3 -5 0.25" />
                            <Vertex pos="3 -5 -0.25" />
                            <Vertex pos="-3 5 0.25" />
                            <Vertex pos="-3 5 -0.25" />
                            <Vertex pos="-3 -5 0.25" />
                            <Vertex pos="-3 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1792 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-11 -50.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 -50.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-14 -55.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -55.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 -0.25 0.25" />
                            <Vertex pos="7 -0.25 -0.25" />
                            <Vertex pos="-7 0.25 0.25" />
                            <Vertex pos="-7 0.25 -0.25" />
                            <Vertex pos="-7 -0.25 0.25" />
                            <Vertex pos="-7 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="13 -50.75 4.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -50.75 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="13 -55.25 4.25" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -55.25 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="23 -50.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -50.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 -0.75" />
                            <Vertex pos="6 0.25 -1.25" />
                            <Vertex pos="6 -0.25 -0.75" />
                            <Vertex pos="6 -0.25 -1.25" />
                            <Vertex pos="-6 0.25 1.25" />
                            <Vertex pos="-6 0.25 0.75" />
                            <Vertex pos="-6 -0.25 1.25" />
                            <Vertex pos="-6 -0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1408 -0.166667 0 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -0.246598" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -0.246598" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="23 -55.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 -55.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 -0.75" />
                            <Vertex pos="6 0.25 -1.25" />
                            <Vertex pos="6 -0.25 -0.75" />
                            <Vertex pos="6 -0.25 -1.25" />
                            <Vertex pos="-6 0.25 1.25" />
                            <Vertex pos="-6 0.25 0.75" />
                            <Vertex pos="-6 -0.25 1.25" />
                            <Vertex pos="-6 -0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1408 -0.166667 0 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.164399 0 0.986394 -0.246598" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.164399 0 -0.986394 -0.246598" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="35 -50.75 2.25" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -50.75 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="35 -55.25 2.25" rot="1 0 0 0" scale="" transform="1 0 0 35 0 1 0 -55.25 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="37.25 -55.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 37.25 0 1 0 -55.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 0.25 0.25" />
                            <Vertex pos="2.25 0.25 -0.25" />
                            <Vertex pos="2.25 -0.25 0.25" />
                            <Vertex pos="2.25 -0.25 -0.25" />
                            <Vertex pos="-2.25 0.25 0.25" />
                            <Vertex pos="-2.25 0.25 -0.25" />
                            <Vertex pos="-2.25 -0.25 0.25" />
                            <Vertex pos="-2.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="35.25 -47 7.75" rot="1 0 0 0" scale="" transform="1 0 0 35.25 0 1 0 -47 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 0.25" />
                            <Vertex pos="0.25 8 -0.25" />
                            <Vertex pos="0.25 -8 0.25" />
                            <Vertex pos="0.25 -8 -0.25" />
                            <Vertex pos="-0.25 8 0.25" />
                            <Vertex pos="-0.25 8 -0.25" />
                            <Vertex pos="-0.25 -8 0.25" />
                            <Vertex pos="-0.25 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="41.75 -44 7.75" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -44 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="-0.25 5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 -5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="38.5 -38.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -38.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="38.5 -38.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -38.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="3.5 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="3.5 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-3.5 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-3.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="35.25 -38.75 9" rot="1 0 0 0" scale="" transform="1 0 0 35.25 0 1 0 -38.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="41.75 -38.75 9" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -38.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1" />
                            <Vertex pos="0.25 0.25 -1" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 -0.25 -1" />
                            <Vertex pos="-0.25 0.25 1" />
                            <Vertex pos="-0.25 0.25 -1" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="37 -38.75 9" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 -38.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 1" />
                            <Vertex pos="1.5 0.25 -1" />
                            <Vertex pos="1.5 -0.25 1" />
                            <Vertex pos="1.5 -0.25 -1" />
                            <Vertex pos="-1.5 0.25 1" />
                            <Vertex pos="-1.5 0.25 -1" />
                            <Vertex pos="-1.5 -0.25 1" />
                            <Vertex pos="-1.5 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_stripe_caution2" texgens="1 0 -2 32 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="40 -38.75 9" rot="1 0 0 0" scale="" transform="1 0 0 40 0 1 0 -38.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 1" />
                            <Vertex pos="1.5 0.25 -1" />
                            <Vertex pos="1.5 -0.25 1" />
                            <Vertex pos="1.5 -0.25 -1" />
                            <Vertex pos="-1.5 0.25 1" />
                            <Vertex pos="-1.5 0.25 -1" />
                            <Vertex pos="-1.5 -0.25 1" />
                            <Vertex pos="-1.5 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_stripe_caution2" texgens="1 0 2 160 0 0 -1 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="38.5 -32.5 10.25" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -32.5 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6 0.25" />
                            <Vertex pos="3 6 -0.25" />
                            <Vertex pos="3 -6 0.25" />
                            <Vertex pos="3 -6 -0.25" />
                            <Vertex pos="-3 6 0.25" />
                            <Vertex pos="-3 6 -0.25" />
                            <Vertex pos="-3 -6 0.25" />
                            <Vertex pos="-3 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1792 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="41.75 -32.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -32.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.25 0.25" />
                            <Vertex pos="0.25 6.25 -0.25" />
                            <Vertex pos="0.25 -6.25 0.25" />
                            <Vertex pos="0.25 -6.25 -0.25" />
                            <Vertex pos="-0.25 6.25 0.25" />
                            <Vertex pos="-0.25 6.25 -0.25" />
                            <Vertex pos="-0.25 -6.25 0.25" />
                            <Vertex pos="-0.25 -6.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="34.5 -29.5 10" rot="1 0 0 0" scale="" transform="1 0 0 34.5 0 1 0 -29.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 0" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 0" />
                            <Vertex pos="-1 3 0" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="32.5 -29.5 9.25" rot="1 0 0 0" scale="" transform="1 0 0 32.5 0 1 0 -29.5 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.750001" />
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 -3 0.750001" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="-1 3 -0.249999" />
                            <Vertex pos="-1 3 -0.75" />
                            <Vertex pos="-1 -3 -0.249999" />
                            <Vertex pos="-1 -3 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="22.5 -29.5 2" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 -29.5 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 7" />
                            <Vertex pos="9 3 6.5" />
                            <Vertex pos="9 -3 7" />
                            <Vertex pos="9 -3 6.5" />
                            <Vertex pos="-9 3 -6.5" />
                            <Vertex pos="-9 3 -7" />
                            <Vertex pos="-9 -3 -6.5" />
                            <Vertex pos="-9 -3 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -0.199999" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.6 0 -0.8 -0.2" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="12.5 -29.5 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -29.5 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.750001" />
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 -3 0.750001" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="-1 3 -0.249999" />
                            <Vertex pos="-1 3 -0.75" />
                            <Vertex pos="-1 -3 -0.249999" />
                            <Vertex pos="-1 -3 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="10.5 -29.5 -6" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -29.5 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.5" />
                            <Vertex pos="1 3 0" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 -3 0" />
                            <Vertex pos="-1 3 0" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 -3 0" />
                            <Vertex pos="-1 -3 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="0.5 -29.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -29.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 3 0.25" />
                            <Vertex pos="9 3 -0.25" />
                            <Vertex pos="9 -3 0.25" />
                            <Vertex pos="9 -3 -0.25" />
                            <Vertex pos="-9 3 0.25" />
                            <Vertex pos="-9 3 -0.25" />
                            <Vertex pos="-9 -3 0.25" />
                            <Vertex pos="-9 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-9.5 -28.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -28.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 0.25" />
                            <Vertex pos="1 2 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -2 0.25" />
                            <Vertex pos="-1 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707106 -0.707107 -0 -2.12132" album="Blasted" material="bm_trim" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-16.5 -27.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -27.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 0.25" />
                            <Vertex pos="6 3 -0.25" />
                            <Vertex pos="6 -3 0.25" />
                            <Vertex pos="6 -3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 -3 0.25" />
                            <Vertex pos="-6 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_trim" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-23.5 -28.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -28.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="Blasted" material="bm_trim" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-30.5 -29.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -29.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 0.25" />
                            <Vertex pos="6 3 -0.25" />
                            <Vertex pos="6 -3 0.25" />
                            <Vertex pos="6 -3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 -3 0.25" />
                            <Vertex pos="-6 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-37.5 -30.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -37.5 0 1 0 -30.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="Blasted" material="bm_trim" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-51.5 -32.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -51.5 0 1 0 -32.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -2 0.25" />
                            <Vertex pos="1 -2 -0.25" />
                            <Vertex pos="-1 2 0.25" />
                            <Vertex pos="-1 2 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-44.5 -31.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -44.5 0 1 0 -31.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 0.25" />
                            <Vertex pos="6 3 -0.25" />
                            <Vertex pos="6 -3 0.25" />
                            <Vertex pos="6 -3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 -3 0.25" />
                            <Vertex pos="-6 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_trim" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-58.5 -33.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -58.5 0 1 0 -33.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 0.25" />
                            <Vertex pos="6 3 -0.25" />
                            <Vertex pos="6 -3 0.25" />
                            <Vertex pos="6 -3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 -3 0.25" />
                            <Vertex pos="-6 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-65.5 -33.5 -6" rot="1 0 0 0" scale="" transform="1 0 0 -65.5 0 1 0 -33.5 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 9.53674e-007" />
                            <Vertex pos="1 3 -0.500001" />
                            <Vertex pos="1 -3 9.53674e-007" />
                            <Vertex pos="1 -3 -0.500001" />
                            <Vertex pos="-1 3 0.500001" />
                            <Vertex pos="-1 3 -9.53674e-007" />
                            <Vertex pos="-1 -3 0.500001" />
                            <Vertex pos="-1 -3 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242537" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242537" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-67.5 -33.5 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 -67.5 0 1 0 -33.5 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 3 -0.749999" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="1 -3 -0.749999" />
                            <Vertex pos="-1 3 0.75" />
                            <Vertex pos="-1 3 0.250001" />
                            <Vertex pos="-1 -3 0.75" />
                            <Vertex pos="-1 -3 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223606" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223606" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-69.5 -33.5 -4.00001" rot="1 0 0 0" scale="" transform="1 0 0 -69.5 0 1 0 -33.5 0 0 1 -4.00001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -0.499998" />
                            <Vertex pos="1 3 -0.999987" />
                            <Vertex pos="1 -3 -0.499998" />
                            <Vertex pos="1 -3 -0.999987" />
                            <Vertex pos="-1 3 0.999987" />
                            <Vertex pos="-1 3 0.499982" />
                            <Vertex pos="-1 -3 0.999987" />
                            <Vertex pos="-1 -3 0.499982" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.599996 0 0.800003 -0.199996" album="" material="bm_tile10_B" texgens="1 0 0 2304 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.599992 0 -0.800006 -0.200004" album="" material="bm_grid_blank4" texgens="-1 0 0 -896 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-70.75 -33.5 -0.249981" rot="1 0 0 0" scale="" transform="1 0 0 -70.75 0 1 0 -33.5 0 0 1 -0.249981 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.249992 3 3.24998" />
                            <Vertex pos="0.249992 3 -3.24998" />
                            <Vertex pos="0.249992 -3 3.24998" />
                            <Vertex pos="0.249992 -3 -3.24998" />
                            <Vertex pos="-0.249992 3 3.24998" />
                            <Vertex pos="-0.249992 3 -2.75005" />
                            <Vertex pos="-0.249992 -3 3.24998" />
                            <Vertex pos="-0.249992 -3 -2.75005" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.249992" album="" material="bm_friction_sand" texgens="0 1 0 -3200 0 0 -1 -576.004 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.249992" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 415.998 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -576.005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -576.005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.24998" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707071 0 -0.707142 -2.12144" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-70.75 -30.25 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -70.75 0 1 0 -30.25 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.25" />
                            <Vertex pos="0.25 0.25 -3.25" />
                            <Vertex pos="0.25 -0.25 3.25" />
                            <Vertex pos="0.25 -0.250002 -3.25" />
                            <Vertex pos="-0.25 0.25 3.25" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 3.25" />
                            <Vertex pos="-0.25 -0.250002 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 3.17891e-007 -0.250001" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-70.75 -36.75 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -70.75 0 1 0 -36.75 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3.25" />
                            <Vertex pos="0.25 0.25 -3.25" />
                            <Vertex pos="0.25 -0.25 3.25" />
                            <Vertex pos="0.25 -0.25 -3.25" />
                            <Vertex pos="-0.25 0.25 3.25" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 3.25" />
                            <Vertex pos="-0.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-70.75 -33.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -70.75 0 1 0 -33.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.5 0.25" />
                            <Vertex pos="0.25 3.5 -0.25" />
                            <Vertex pos="0.25 -3.5 0.25" />
                            <Vertex pos="0.25 -3.5 -0.25" />
                            <Vertex pos="-0.25 3.5 0.25" />
                            <Vertex pos="-0.25 3.5 -0.25" />
                            <Vertex pos="-0.25 -3.5 0.25" />
                            <Vertex pos="-0.25 -3.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4736 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 4864 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-77 -33.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -77 0 1 0 -33.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 0.25" />
                            <Vertex pos="6 3 -0.25" />
                            <Vertex pos="6 -3 0.25" />
                            <Vertex pos="6 -3 -0.25" />
                            <Vertex pos="-6 3 0.25" />
                            <Vertex pos="-6 3 -0.25" />
                            <Vertex pos="-6 -3 0.25" />
                            <Vertex pos="-6 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 1024 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-81 -26.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -26.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="-81 -22 3.375" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -22 0 0 1 3.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.375" />
                            <Vertex pos="2 0.5 -0.125" />
                            <Vertex pos="2 -0.5 0.125" />
                            <Vertex pos="2 -0.5 -0.375" />
                            <Vertex pos="-2 0.5 0.375" />
                            <Vertex pos="-2 0.5 -0.125" />
                            <Vertex pos="-2 -0.5 0.125" />
                            <Vertex pos="-2 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242535" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-81 -21 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -21 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.499999" />
                            <Vertex pos="2 0.5 7.15256e-007" />
                            <Vertex pos="2 -0.5 -4.76837e-007" />
                            <Vertex pos="2 -0.5 -0.499999" />
                            <Vertex pos="-2 0.5 0.499999" />
                            <Vertex pos="-2 0.5 7.15256e-007" />
                            <Vertex pos="-2 -0.5 -4.76837e-007" />
                            <Vertex pos="-2 -0.5 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="-81 -20 4.375" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -20 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.625" />
                            <Vertex pos="2 0.5 0.125" />
                            <Vertex pos="2 -0.5 -0.125" />
                            <Vertex pos="2 -0.5 -0.624999" />
                            <Vertex pos="-2 0.5 0.625" />
                            <Vertex pos="-2 0.5 0.125" />
                            <Vertex pos="-2 -0.5 -0.125" />
                            <Vertex pos="-2 -0.5 -0.624999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="-81 -19 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -19 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.75" />
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="2 -0.5 -0.75" />
                            <Vertex pos="-2 0.5 0.75" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                            <Vertex pos="-2 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="-81 3.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 3.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 0.25" />
                            <Vertex pos="2 4 -0.25" />
                            <Vertex pos="2 -4 0.25" />
                            <Vertex pos="2 -4 -0.25" />
                            <Vertex pos="-2 4 0.25" />
                            <Vertex pos="-2 4 -0.25" />
                            <Vertex pos="-2 -4 0.25" />
                            <Vertex pos="-2 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-86 18.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -86 0 1 0 18.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="-95 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 0.25" />
                            <Vertex pos="10 2 -0.25" />
                            <Vertex pos="10 -2 0.25" />
                            <Vertex pos="10 -2 -0.25" />
                            <Vertex pos="-10 2 0.25" />
                            <Vertex pos="-10 2 -0.25" />
                            <Vertex pos="-10 -2 0.25" />
                            <Vertex pos="-10 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -2048 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1280 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="-86 28.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -86 0 1 0 28.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="-81 17.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 17.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="-81 29.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 29.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="-76 18.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -76 0 1 0 18.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="-76 28.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -76 0 1 0 28.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -3 0.25" />
                            <Vertex pos="3 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="-81 11.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 11.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.99999 4 -3.75" />
                            <Vertex pos="7.99999 4 -4.25" />
                            <Vertex pos="16 -4 4.25" />
                            <Vertex pos="16 -4 3.75" />
                            <Vertex pos="-7.99999 4 -3.75" />
                            <Vertex pos="-7.99999 4 -4.25" />
                            <Vertex pos="-16 -4 4.25" />
                            <Vertex pos="-16 -4 3.75" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -8.48527" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -8.48528" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.176776" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 -0.176776" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="-91 16.5 5.74998" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 16.5 0 0 1 5.74998 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5 -1.74999" />
                            <Vertex pos="2 5 -2.25001" />
                            <Vertex pos="2 -0.999999 -1.74999" />
                            <Vertex pos="2 -0.999999 -2.25001" />
                            <Vertex pos="-2 5 2.25001" />
                            <Vertex pos="-2 5 1.74999" />
                            <Vertex pos="-2 -5 2.25001" />
                            <Vertex pos="-2 -5 1.74999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 2688 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176786" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 1.96685e-007 -0.707107 -0.176785" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-91 30.5 5.74998" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 30.5 0 0 1 5.74998 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 -1.74999" />
                            <Vertex pos="2 1 -2.25001" />
                            <Vertex pos="2 -5 -1.74999" />
                            <Vertex pos="2 -5 -2.25001" />
                            <Vertex pos="-2 5 2.25001" />
                            <Vertex pos="-2 5 1.74999" />
                            <Vertex pos="-2 -5 2.25001" />
                            <Vertex pos="-2 -5 1.74999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176786" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 -1.96685e-007 -0.707107 -0.176786" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="-95 23.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 23.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 12 -1.75" />
                            <Vertex pos="2 12 -2.25" />
                            <Vertex pos="2 -12 -1.75" />
                            <Vertex pos="2 -12 -2.25" />
                            <Vertex pos="-2 16 2.25" />
                            <Vertex pos="-2 16 1.75" />
                            <Vertex pos="-2 -16 2.25" />
                            <Vertex pos="-2 -16 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1920 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1792 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -9.8995" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -9.8995" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176779" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.17678" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-71 16.5 5.75001" rot="1 0 0 0" scale="" transform="1 0 0 -71 0 1 0 16.5 0 0 1 5.75001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5 2.25" />
                            <Vertex pos="2 5 1.75" />
                            <Vertex pos="2 -5 2.25" />
                            <Vertex pos="2 -5 1.75" />
                            <Vertex pos="-2 5 -1.75" />
                            <Vertex pos="-2 5 -2.25" />
                            <Vertex pos="-2 -1 -1.75" />
                            <Vertex pos="-2 -1 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 -1.68587e-007 0.707107 -0.176774" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 -6.7435e-008 -0.707107 -0.176774" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-71 30.5 5.75001" rot="1 0 0 0" scale="" transform="1 0 0 -71 0 1 0 30.5 0 0 1 5.75001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5 2.25" />
                            <Vertex pos="2 5 1.75" />
                            <Vertex pos="2 -4.99999 2.25" />
                            <Vertex pos="2 -4.99999 1.75" />
                            <Vertex pos="-2 0.999994 -1.75" />
                            <Vertex pos="-2 0.999994 -2.25" />
                            <Vertex pos="-2 -4.99999 -1.75" />
                            <Vertex pos="-2 -4.99999 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.99999" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 1.68588e-007 0.707107 -0.176774" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 6.7435e-008 -0.707107 -0.176774" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-67 23.5 9.75001" rot="1 0 0 0" scale="" transform="1 0 0 -67 0 1 0 23.5 0 0 1 9.75001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 16 2.25" />
                            <Vertex pos="2 16 1.75" />
                            <Vertex pos="2 -16 2.25" />
                            <Vertex pos="2 -16 1.75" />
                            <Vertex pos="-2 12 -1.75" />
                            <Vertex pos="-2 12 -2.25" />
                            <Vertex pos="-2 -12 -1.75" />
                            <Vertex pos="-2 -12 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 2432 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2304 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -9.89949" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -9.89949" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176779" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176779" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-81 35.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 35.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 4.25" />
                            <Vertex pos="2 4 3.75" />
                            <Vertex pos="2 -4 -3.75" />
                            <Vertex pos="2 -4 -4.25" />
                            <Vertex pos="-2 4 4.25" />
                            <Vertex pos="-2 4 3.75" />
                            <Vertex pos="-2 -4 -3.75" />
                            <Vertex pos="-2 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176776" album="" material="bm_friction_sand" texgens="1 0 0 0 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176776" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-72 35.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -72 0 1 0 35.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.00001 4 4.25" />
                            <Vertex pos="7.00001 4 3.75" />
                            <Vertex pos="-0.999992 -4 -3.75" />
                            <Vertex pos="-0.999992 -4 -4.25" />
                            <Vertex pos="-7.00001 4 4.25" />
                            <Vertex pos="-7.00001 4 3.75" />
                            <Vertex pos="-7.00001 -4 -3.75" />
                            <Vertex pos="-7.00001 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.12133" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -7.00001" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -1024 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 1152 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_tile10_B" texgens="1 0 0 1280 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-90 35.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -90 0 1 0 35.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 4 4.25" />
                            <Vertex pos="7 4 3.75" />
                            <Vertex pos="7 -4 -3.75" />
                            <Vertex pos="7 -4 -4.25" />
                            <Vertex pos="-7 4 4.25" />
                            <Vertex pos="-7 4 3.75" />
                            <Vertex pos="1 -4 -3.75" />
                            <Vertex pos="1 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.12132" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_tile10_B" texgens="1 0 0 -768 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-81 43.5 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 43.5 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 4.25" />
                            <Vertex pos="2 4 3.75" />
                            <Vertex pos="2 -4 -3.75" />
                            <Vertex pos="2 -4 -4.25" />
                            <Vertex pos="-2 4 4.25" />
                            <Vertex pos="-2 4 3.75" />
                            <Vertex pos="-2 -4 -3.75" />
                            <Vertex pos="-2 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176778" album="" material="bm_friction_sand" texgens="1 0 0 0 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176778" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-67 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -67 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10 2 0.25" />
                            <Vertex pos="10 2 -0.25" />
                            <Vertex pos="10 -2 0.25" />
                            <Vertex pos="10 -2 -0.25" />
                            <Vertex pos="-10 2 0.25" />
                            <Vertex pos="-10 2 -0.25" />
                            <Vertex pos="-10 -2 0.25" />
                            <Vertex pos="-10 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -10" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -10" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="-53 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 4 0.25" />
                            <Vertex pos="4 4 -0.25" />
                            <Vertex pos="4 -4 0.25" />
                            <Vertex pos="4 -4 -0.25" />
                            <Vertex pos="-4 4 0.25" />
                            <Vertex pos="-4 4 -0.25" />
                            <Vertex pos="-4 -4 0.25" />
                            <Vertex pos="-4 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 1792 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -1536 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-106 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -106 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 -6 0.25" />
                            <Vertex pos="1 -6 -0.25" />
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="-1 -6 0.25" />
                            <Vertex pos="-1 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 2944 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_trim" texgens="0 -1 0 -2816 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-111 28.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 28.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.25" />
                            <Vertex pos="4 1 -0.25" />
                            <Vertex pos="4 -1 0.25" />
                            <Vertex pos="4 -1 -0.25" />
                            <Vertex pos="-4 1 0.25" />
                            <Vertex pos="-4 1 -0.25" />
                            <Vertex pos="-4 -1 0.25" />
                            <Vertex pos="-4 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_trim" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-111 18.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 18.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 0.25" />
                            <Vertex pos="4 1 -0.25" />
                            <Vertex pos="4 -1 0.25" />
                            <Vertex pos="4 -1 -0.25" />
                            <Vertex pos="-4 1 0.25" />
                            <Vertex pos="-4 1 -0.25" />
                            <Vertex pos="-4 -1 0.25" />
                            <Vertex pos="-4 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_trim" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-116 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -116 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 0.25" />
                            <Vertex pos="1 6 -0.25" />
                            <Vertex pos="1 -6 0.25" />
                            <Vertex pos="1 -6 -0.25" />
                            <Vertex pos="-1 6 0.25" />
                            <Vertex pos="-1 6 -0.25" />
                            <Vertex pos="-1 -6 0.25" />
                            <Vertex pos="-1 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_trim" texgens="0 1 0 2944 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -2816 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-108 23.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -108 0 1 0 23.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_trim" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-114 23.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -114 0 1 0 23.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 0.25" />
                            <Vertex pos="1 4 -0.25" />
                            <Vertex pos="1 -4 0.25" />
                            <Vertex pos="1 -4 -0.25" />
                            <Vertex pos="-1 4 0.25" />
                            <Vertex pos="-1 4 -0.25" />
                            <Vertex pos="-1 -4 0.25" />
                            <Vertex pos="-1 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_trim" texgens="0 1 0 3456 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 -3328 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-111 26.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 26.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_trim" texgens="1 0 0 -640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -512 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-111 20.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 20.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="2 -1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 4224 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -4096 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_trim" texgens="-1 0 0 768 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -512 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-111 23.5 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 23.5 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3968 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3840 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 -512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-81 50.5 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 50.5 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 0.25" />
                            <Vertex pos="2 3 -0.25" />
                            <Vertex pos="2 -3 0.25" />
                            <Vertex pos="2 -3 -0.25" />
                            <Vertex pos="-2 3 0.25" />
                            <Vertex pos="-2 3 -0.25" />
                            <Vertex pos="-2 -3 0.25" />
                            <Vertex pos="-2 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 3712 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -3584 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="5" type="999" pos="-81 26.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 26.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 4" />
                            <Vertex pos="2 1 -4" />
                            <Vertex pos="2 -7 4" />
                            <Vertex pos="2 -7 -4" />
                            <Vertex pos="-2 1 4" />
                            <Vertex pos="-2 1 -4" />
                            <Vertex pos="-2 -7 4" />
                            <Vertex pos="-2 -7 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="1" type="999" pos="-78 23.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -78 0 1 0 23.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -4" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -4" />
                            <Vertex pos="-7 2 2" />
                            <Vertex pos="-7 2 -4" />
                            <Vertex pos="-7 -2 2" />
                            <Vertex pos="-7 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile10_B" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-76 18.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -76 0 1 0 18.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 11.75" />
                            <Vertex pos="3 3 -11.75" />
                            <Vertex pos="3 -3 11.75" />
                            <Vertex pos="3 -3 -11.75" />
                            <Vertex pos="-3 3 11.75" />
                            <Vertex pos="-3 3 -11.75" />
                            <Vertex pos="-3 -3 11.75" />
                            <Vertex pos="-3 -3 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-86 18.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -86 0 1 0 18.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 11.75" />
                            <Vertex pos="3 3 -11.75" />
                            <Vertex pos="3 -3 11.75" />
                            <Vertex pos="3 -3 -11.75" />
                            <Vertex pos="-3 3 11.75" />
                            <Vertex pos="-3 3 -11.75" />
                            <Vertex pos="-3 -3 11.75" />
                            <Vertex pos="-3 -3 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-76 28.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -76 0 1 0 28.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 11.75" />
                            <Vertex pos="3 3 -11.75" />
                            <Vertex pos="3 -3 11.75" />
                            <Vertex pos="3 -3 -11.75" />
                            <Vertex pos="-3 3 11.75" />
                            <Vertex pos="-3 3 -11.75" />
                            <Vertex pos="-3 -3 11.75" />
                            <Vertex pos="-3 -3 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-86 28.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -86 0 1 0 28.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 11.75" />
                            <Vertex pos="3 3 -11.75" />
                            <Vertex pos="3 -3 11.75" />
                            <Vertex pos="3 -3 -11.75" />
                            <Vertex pos="-3 3 11.75" />
                            <Vertex pos="-3 3 -11.75" />
                            <Vertex pos="-3 -3 11.75" />
                            <Vertex pos="-3 -3 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 384 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 768 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-91 23.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 23.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 3.75" />
                            <Vertex pos="6 2 -3.75" />
                            <Vertex pos="6 -2 3.75" />
                            <Vertex pos="6 -2 -3.75" />
                            <Vertex pos="-5.99999 2 3.75" />
                            <Vertex pos="2.00001 2 -3.75" />
                            <Vertex pos="-5.99999 -2 3.75" />
                            <Vertex pos="2.00001 -2 -3.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.683941 -0 -0.729537 -1.36788" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_tile10_B" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.75" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-71 23.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -71 0 1 0 23.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 3.75" />
                            <Vertex pos="-2 2 -3.75" />
                            <Vertex pos="6 -2 3.75" />
                            <Vertex pos="-2 -2 -3.75" />
                            <Vertex pos="-6 2 3.75" />
                            <Vertex pos="-6 2 -3.75" />
                            <Vertex pos="-6 -2 3.75" />
                            <Vertex pos="-6 -2 -3.75" />
                        </Vertices>
                        <Face id="0" plane="0.683941 0 -0.729537 -1.36788" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_tile10_B" texgens="1 0 0 -512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3.75" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-81 29.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 29.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 11.75" />
                            <Vertex pos="2 2 -11.75" />
                            <Vertex pos="2 -2 11.75" />
                            <Vertex pos="2 -2 -11.75" />
                            <Vertex pos="-2 2 11.75" />
                            <Vertex pos="-2 2 -11.75" />
                            <Vertex pos="-2 -2 11.75" />
                            <Vertex pos="-2 -2 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-81 17.5 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 17.5 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 11.75" />
                            <Vertex pos="2 2 -11.75" />
                            <Vertex pos="2 -2 11.75" />
                            <Vertex pos="2 -2 -11.75" />
                            <Vertex pos="-2 2 11.75" />
                            <Vertex pos="-2 2 -11.75" />
                            <Vertex pos="-2 -2 11.75" />
                            <Vertex pos="-2 -2 -11.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.75" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-75 23.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -75 0 1 0 23.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 8" />
                            <Vertex pos="2 2 -8" />
                            <Vertex pos="2 -2 8" />
                            <Vertex pos="2 -2 -8" />
                            <Vertex pos="-2 2 8" />
                            <Vertex pos="-2 2 -8" />
                            <Vertex pos="-2 -2 8" />
                            <Vertex pos="-2 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-87 23.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -87 0 1 0 23.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 8" />
                            <Vertex pos="2 2 -8" />
                            <Vertex pos="2 -2 8" />
                            <Vertex pos="2 -2 -8" />
                            <Vertex pos="-2 2 8" />
                            <Vertex pos="-2 2 -8" />
                            <Vertex pos="-2 -2 8" />
                            <Vertex pos="-2 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="35.25 -35.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 35.25 0 1 0 -35.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.75 0.25" />
                            <Vertex pos="0.25 2.75 -0.25" />
                            <Vertex pos="0.25 -2.75 0.25" />
                            <Vertex pos="0.25 -2.75 -0.25" />
                            <Vertex pos="-0.25 2.75 0.25" />
                            <Vertex pos="-0.25 2.75 -0.25" />
                            <Vertex pos="-0.25 -2.75 0.25" />
                            <Vertex pos="-0.25 -2.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -2240 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.75" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="38.5 -26.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -26.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="34.5 -26.25 10" rot="1 0 0 0" scale="" transform="1 0 0 34.5 0 1 0 -26.25 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="34.5 -32.75 10" rot="1 0 0 0" scale="" transform="1 0 0 34.5 0 1 0 -32.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="32.5 -26.25 9.25" rot="1 0 0 0" scale="" transform="1 0 0 32.5 0 1 0 -26.25 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.750001" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 -0.25 0.750001" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.249999" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -0.249999" />
                            <Vertex pos="-1 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0.5 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="32.5 -32.75 9.25" rot="1 0 0 0" scale="" transform="1 0 0 32.5 0 1 0 -32.75 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.750001" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 -0.25 0.750001" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.249999" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -0.249999" />
                            <Vertex pos="-1 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0.5 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="22.5 -26.25 2" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 -26.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.249998 7" />
                            <Vertex pos="9 0.249998 6.5" />
                            <Vertex pos="9 -0.25 7" />
                            <Vertex pos="9 -0.25 6.5" />
                            <Vertex pos="-9 0.249998 -6.5" />
                            <Vertex pos="-9 0.249998 -7" />
                            <Vertex pos="-9 -0.25 -6.5" />
                            <Vertex pos="-9 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.249998" album="" material="bm_edge_white" texgens="-1 0 0 -2176 0.75 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -0.2" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.6 0 -0.8 -0.2" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="22.5 -32.75 2" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 -32.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 7" />
                            <Vertex pos="9 0.25 6.5" />
                            <Vertex pos="9 -0.25 7" />
                            <Vertex pos="9 -0.25 6.5" />
                            <Vertex pos="-9 0.25 -6.5" />
                            <Vertex pos="-9 0.25 -7" />
                            <Vertex pos="-9 -0.25 -6.5" />
                            <Vertex pos="-9 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 0 -1 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0.75 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -0.200001" album="" material="bm_edge_white" texgens="1 0 0 -1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.6 0 -0.8 -0.200001" album="" material="bm_edge_white" texgens="-1 0 0 1152 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="10.5 -26.25 -6" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -26.25 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="10.5 -32.75 -6" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 -32.75 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="12.5 -26.25 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -26.25 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.750001" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 -0.25 0.750001" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.249999" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -0.249999" />
                            <Vertex pos="-1 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 0.5 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="12.5 -32.75 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 12.5 0 1 0 -32.75 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.750001" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 -0.25 0.750001" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.249999" />
                            <Vertex pos="-1 0.25 -0.75" />
                            <Vertex pos="-1 -0.25 -0.249999" />
                            <Vertex pos="-1 -0.25 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 0.5 0 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223608" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="0.5 -32.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -32.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="9 -0.25 0.25" />
                            <Vertex pos="9 -0.25 -0.25" />
                            <Vertex pos="-9 0.25 0.25" />
                            <Vertex pos="-9 0.25 -0.25" />
                            <Vertex pos="-9 -0.25 0.25" />
                            <Vertex pos="-9 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-58.5 -30.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -58.5 0 1 0 -30.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-65.5 -36.75 -6" rot="1 0 0 0" scale="" transform="1 0 0 -65.5 0 1 0 -36.75 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 0.25 -0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="1 -0.25 -0.5" />
                            <Vertex pos="-1 0.25 0.5" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 -0.25 0.5" />
                            <Vertex pos="-1 -0.25 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="-67.5 -36.75 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 -67.5 0 1 0 -36.75 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 0.25 -0.749999" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="1 -0.25 -0.749999" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="-1 0.25 0.250001" />
                            <Vertex pos="-1 -0.25 0.75" />
                            <Vertex pos="-1 -0.25 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 -0.5 0 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223606" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223606" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="-69.5 -36.75 -4" rot="1 0 0 0" scale="" transform="1 0 0 -69.5 0 1 0 -36.75 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.500004" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 -0.500004" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1.00001" />
                            <Vertex pos="-1 0.25 0.499995" />
                            <Vertex pos="-1 -0.25 1.00001" />
                            <Vertex pos="-1 -0.25 0.499995" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 -0.75 0 -1 64.0013 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.600002 0 0.799998 -0.2" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.6 0 -0.8 -0.200004" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-65.5 -30.25 -6" rot="1 0 0 0" scale="" transform="1 0 0 -65.5 0 1 0 -30.25 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0" />
                            <Vertex pos="1 0.25 -0.5" />
                            <Vertex pos="1 -0.25 0" />
                            <Vertex pos="1 -0.25 -0.5" />
                            <Vertex pos="-1 0.25 0.5" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 -0.25 0.5" />
                            <Vertex pos="-1 -0.25 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-67.5 -30.25 -5.25" rot="1 0 0 0" scale="" transform="1 0 0 -67.5 0 1 0 -30.25 0 0 1 -5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 0.25 -0.749999" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="1 -0.25 -0.749999" />
                            <Vertex pos="-1 0.25 0.75" />
                            <Vertex pos="-1 0.25 0.250001" />
                            <Vertex pos="-1 -0.25 0.75" />
                            <Vertex pos="-1 -0.25 0.250001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 -0.5 0 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223606" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223606" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-69.5 -30.25 -4" rot="1 0 0 0" scale="" transform="1 0 0 -69.5 0 1 0 -30.25 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -0.500004" />
                            <Vertex pos="1 0.25 -1" />
                            <Vertex pos="1 -0.25 -0.500004" />
                            <Vertex pos="1 -0.25 -1" />
                            <Vertex pos="-1 0.25 1.00001" />
                            <Vertex pos="-1 0.25 0.499995" />
                            <Vertex pos="-1 -0.25 1.00001" />
                            <Vertex pos="-1 -0.25 0.499995" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 -0.75 0 -1 64.0013 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.600002 0 0.799998 -0.2" album="" material="bm_edge_white" texgens="1 0 0 1024 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.6 0 -0.8 -0.200004" album="" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-77.25 -36.75 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -77.25 0 1 0 -36.75 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.25 0.25 0.25" />
                            <Vertex pos="6.25 0.25 -0.25" />
                            <Vertex pos="6.25 -0.25 0.25" />
                            <Vertex pos="6.25 -0.25 -0.25" />
                            <Vertex pos="-6.25 0.25 0.25" />
                            <Vertex pos="-6.25 0.25 -0.25" />
                            <Vertex pos="-6.25 -0.25 0.25" />
                            <Vertex pos="-6.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.25" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -320 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 448 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-74.75 -30.25 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -74.75 0 1 0 -30.25 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.75 0.25 0.25" />
                            <Vertex pos="3.75 0.25 -0.25" />
                            <Vertex pos="3.75 -0.25 0.25" />
                            <Vertex pos="3.75 -0.25 -0.25" />
                            <Vertex pos="-3.75 0.25 0.25" />
                            <Vertex pos="-3.75 0.25 -0.25" />
                            <Vertex pos="-3.75 -0.25 0.25" />
                            <Vertex pos="-3.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.75" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 320 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -192 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-83.25 -29.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -29.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 7 0.25" />
                            <Vertex pos="0.25 7 -0.25" />
                            <Vertex pos="0.25 -7 0.25" />
                            <Vertex pos="0.25 -7 -0.25" />
                            <Vertex pos="-0.25 7 0.25" />
                            <Vertex pos="-0.25 7 -0.25" />
                            <Vertex pos="-0.25 -7 0.25" />
                            <Vertex pos="-0.25 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3840 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3968 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-78.75 -26.5 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -26.5 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 3200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-78.75 -22 3.375" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -22 0 0 1 3.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 0.125" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 0.125" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.25 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242535" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-78.75 -21 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -21 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.499999" />
                            <Vertex pos="0.25 0.5 7.15256e-007" />
                            <Vertex pos="0.25 -0.5 -4.76837e-007" />
                            <Vertex pos="0.25 -0.5 -0.499999" />
                            <Vertex pos="-0.25 0.5 0.499999" />
                            <Vertex pos="-0.25 0.5 7.15256e-007" />
                            <Vertex pos="-0.25 -0.5 -4.76837e-007" />
                            <Vertex pos="-0.25 -0.5 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.5 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-78.75 -20 4.375" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -20 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.625" />
                            <Vertex pos="0.25 0.5 0.125" />
                            <Vertex pos="0.25 -0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 -0.624999" />
                            <Vertex pos="-0.25 0.5 0.625" />
                            <Vertex pos="-0.25 0.5 0.125" />
                            <Vertex pos="-0.25 -0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 -0.624999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.2" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-78.75 -19 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -19 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.75" />
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 -0.75" />
                            <Vertex pos="-0.25 0.5 0.75" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-83.25 -22 3.375" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -22 0 0 1 3.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 0.125" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 0.125" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0.25 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242535" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-83.25 -21 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -21 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.499999" />
                            <Vertex pos="0.25 0.5 7.15256e-007" />
                            <Vertex pos="0.25 -0.5 -4.76837e-007" />
                            <Vertex pos="0.25 -0.5 -0.499999" />
                            <Vertex pos="-0.25 0.5 0.499999" />
                            <Vertex pos="-0.25 0.5 7.15256e-007" />
                            <Vertex pos="-0.25 -0.5 -4.76837e-007" />
                            <Vertex pos="-0.25 -0.5 -0.499999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0.5 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-83.25 -20 4.375" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -20 0 0 1 4.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.625" />
                            <Vertex pos="0.25 0.5 0.125" />
                            <Vertex pos="0.25 -0.5 -0.125" />
                            <Vertex pos="0.25 -0.5 -0.624999" />
                            <Vertex pos="-0.25 0.5 0.625" />
                            <Vertex pos="-0.25 0.5 0.125" />
                            <Vertex pos="-0.25 -0.5 -0.125" />
                            <Vertex pos="-0.25 -0.5 -0.624999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.2" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-83.25 -19 5.25" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -19 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.75" />
                            <Vertex pos="0.25 0.5 0.25" />
                            <Vertex pos="0.25 -0.5 -0.25" />
                            <Vertex pos="0.25 -0.5 -0.75" />
                            <Vertex pos="-0.25 0.5 0.75" />
                            <Vertex pos="-0.25 0.5 0.25" />
                            <Vertex pos="-0.25 -0.5 -0.25" />
                            <Vertex pos="-0.25 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 1 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-53 23.5 7" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 23.5 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 2 -3" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="2 -2 -3" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 2 -3" />
                            <Vertex pos="-2 -2 3" />
                            <Vertex pos="-2 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-78.75 3.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 3.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-83.25 3.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 3.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.25" />
                            <Vertex pos="0.25 4 -0.25" />
                            <Vertex pos="0.25 -4 0.25" />
                            <Vertex pos="0.25 -4 -0.25" />
                            <Vertex pos="-0.25 4 0.25" />
                            <Vertex pos="-0.25 4 -0.25" />
                            <Vertex pos="-0.25 -4 0.25" />
                            <Vertex pos="-0.25 -4 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-78.75 50.5 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 50.5 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-83.25 50.5 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 50.5 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="-78.75 43.5 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 43.5 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 4.25" />
                            <Vertex pos="0.25 4 3.75" />
                            <Vertex pos="0.25 -4 -3.75" />
                            <Vertex pos="0.25 -4 -4.25" />
                            <Vertex pos="-0.25 4 4.25" />
                            <Vertex pos="-0.25 4 3.75" />
                            <Vertex pos="-0.25 -4 -3.75" />
                            <Vertex pos="-0.25 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -896 0 1 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1152 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="-83.25 43.5 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 43.5 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 4.25" />
                            <Vertex pos="0.25 4 3.75" />
                            <Vertex pos="0.25 -4 -3.75" />
                            <Vertex pos="0.25 -4 -4.25" />
                            <Vertex pos="-0.25 4 4.25" />
                            <Vertex pos="-0.25 4 3.75" />
                            <Vertex pos="-0.25 -4 -3.75" />
                            <Vertex pos="-0.25 -4 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -1024 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 1 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="-90.5 7.25 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -90.5 0 1 0 7.25 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 -0.25 0.25" />
                            <Vertex pos="7 -0.25 -0.25" />
                            <Vertex pos="-7 0.25 0.25" />
                            <Vertex pos="-7 0.25 -0.25" />
                            <Vertex pos="-7 -0.25 0.25" />
                            <Vertex pos="-7 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="-71.5 7.25 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -71.5 0 1 0 7.25 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 -0.25 0.25" />
                            <Vertex pos="7 -0.25 -0.25" />
                            <Vertex pos="-7 0.25 0.25" />
                            <Vertex pos="-7 0.25 -0.25" />
                            <Vertex pos="-7 -0.25 0.25" />
                            <Vertex pos="-7 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="-90.5 39.75 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -90.5 0 1 0 39.75 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 -0.25 0.25" />
                            <Vertex pos="7 -0.25 -0.25" />
                            <Vertex pos="-7 0.25 0.25" />
                            <Vertex pos="-7 0.25 -0.25" />
                            <Vertex pos="-7 -0.25 0.25" />
                            <Vertex pos="-7 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-71.5 39.75 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -71.5 0 1 0 39.75 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 -0.25 0.25" />
                            <Vertex pos="7 -0.25 -0.25" />
                            <Vertex pos="-7 0.25 0.25" />
                            <Vertex pos="-7 0.25 -0.25" />
                            <Vertex pos="-7 -0.25 0.25" />
                            <Vertex pos="-7 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-64.75 23.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -64.75 0 1 0 23.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 16 0.25" />
                            <Vertex pos="0.25 16 -0.25" />
                            <Vertex pos="0.25 -16 0.25" />
                            <Vertex pos="0.25 -16 -0.25" />
                            <Vertex pos="-0.25 16 0.25" />
                            <Vertex pos="-0.25 16 -0.25" />
                            <Vertex pos="-0.25 -16 0.25" />
                            <Vertex pos="-0.25 -16 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-97.25 23.5 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -97.25 0 1 0 23.5 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 16 0.25" />
                            <Vertex pos="0.25 16 -0.25" />
                            <Vertex pos="0.25 -16 0.25" />
                            <Vertex pos="0.25 -16 -0.25" />
                            <Vertex pos="-0.25 16 0.25" />
                            <Vertex pos="-0.25 16 -0.25" />
                            <Vertex pos="-0.25 -16 0.25" />
                            <Vertex pos="-0.25 -16 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -16" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-97 25.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 25.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-97 21.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -97 0 1 0 21.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-117.25 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -117.25 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6.5 0.25" />
                            <Vertex pos="0.25 6.5 -0.25" />
                            <Vertex pos="0.25 -6.5 0.25" />
                            <Vertex pos="0.25 -6.5 -0.25" />
                            <Vertex pos="-0.25 6.5 0.25" />
                            <Vertex pos="-0.25 6.5 -0.25" />
                            <Vertex pos="-0.25 -6.5 0.25" />
                            <Vertex pos="-0.25 -6.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-104.75 28 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -104.75 0 1 0 28 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-104.75 19 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -104.75 0 1 0 19 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0.25" />
                            <Vertex pos="0.25 2 -0.25" />
                            <Vertex pos="0.25 -2 0.25" />
                            <Vertex pos="0.25 -2 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 -2 0.25" />
                            <Vertex pos="-0.25 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-111 17.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 17.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3648 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3520 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-111 29.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 29.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 3648 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 -3520 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2048 0 -1 0 -3520 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-65 25.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 25.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-65 21.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -65 0 1 0 21.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.25 0.25" />
                            <Vertex pos="8 0.25 -0.25" />
                            <Vertex pos="8 -0.25 0.25" />
                            <Vertex pos="8 -0.25 -0.25" />
                            <Vertex pos="-8 0.25 0.25" />
                            <Vertex pos="-8 0.25 -0.25" />
                            <Vertex pos="-8 -0.25 0.25" />
                            <Vertex pos="-8 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="" material="bm_edge_white" texgens="0 -1 0 192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-48.75 23.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -48.75 0 1 0 23.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4.5 0.25" />
                            <Vertex pos="0.25 4.5 -0.25" />
                            <Vertex pos="0.25 -4.5 0.25" />
                            <Vertex pos="0.25 -4.5 -0.25" />
                            <Vertex pos="-0.25 4.5 0.25" />
                            <Vertex pos="-0.25 4.5 -0.25" />
                            <Vertex pos="-0.25 -4.5 0.25" />
                            <Vertex pos="-0.25 -4.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-57.25 20 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -57.25 0 1 0 20 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-57.25 27 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -57.25 0 1 0 27 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-53 27.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 27.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-53 19.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 19.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="4 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-4 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-4 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 512 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-69.25 23.5 7.50001" rot="1 0 0 0" scale="" transform="1 0 0 -69.25 0 1 0 23.5 0 0 1 7.50001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 0.5" />
                            <Vertex pos="0.25 1.5 -4.76837e-007" />
                            <Vertex pos="0.25 -1.5 0.5" />
                            <Vertex pos="0.25 -1.5 -4.76837e-007" />
                            <Vertex pos="-0.25 1.5 0" />
                            <Vertex pos="-0.25 1.5 -0.5" />
                            <Vertex pos="-0.25 -1.5 0" />
                            <Vertex pos="-0.25 -1.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-71 25.25 5.74999" rot="1 0 0 0" scale="" transform="1 0 0 -71 0 1 0 25.25 0 0 1 5.74999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.249998 2.25" />
                            <Vertex pos="2 0.249998 1.75" />
                            <Vertex pos="2 -0.249998 2.25" />
                            <Vertex pos="2 -0.249998 1.75" />
                            <Vertex pos="-2 0.249998 -1.75" />
                            <Vertex pos="-2 0.249998 -2.25" />
                            <Vertex pos="-2 -0.249998 -1.75" />
                            <Vertex pos="-2 -0.249998 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1344 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1216 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.249998" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.249998" album="" material="bm_edge_white" texgens="1 0 0 -384 1 0 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-71 21.75 5.74999" rot="1 0 0 0" scale="" transform="1 0 0 -71 0 1 0 21.75 0 0 1 5.74999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 2.25" />
                            <Vertex pos="2 0.25 1.75" />
                            <Vertex pos="2 -0.25 2.25" />
                            <Vertex pos="2 -0.25 1.75" />
                            <Vertex pos="-2 0.25 -1.75" />
                            <Vertex pos="-2 0.25 -2.25" />
                            <Vertex pos="-2 -0.25 -1.75" />
                            <Vertex pos="-2 -0.25 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1344 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -1216 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 1 0 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-92.75 23.5 7.49999" rot="1 0 0 0" scale="" transform="1 0 0 -92.75 0 1 0 23.5 0 0 1 7.49999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.5 4.76837e-007" />
                            <Vertex pos="0.25 1.5 -0.5" />
                            <Vertex pos="0.25 -1.5 4.76837e-007" />
                            <Vertex pos="0.25 -1.5 -0.5" />
                            <Vertex pos="-0.25 1.5 0.5" />
                            <Vertex pos="-0.25 1.5 0" />
                            <Vertex pos="-0.25 -1.5 0.5" />
                            <Vertex pos="-0.25 -1.5 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -2944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-91 21.75 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 21.75 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 -1.75" />
                            <Vertex pos="2 0.25 -2.25" />
                            <Vertex pos="2 -0.25 -1.75" />
                            <Vertex pos="2 -0.25 -2.25" />
                            <Vertex pos="-2 0.25 2.25" />
                            <Vertex pos="-2 0.25 1.75" />
                            <Vertex pos="-2 -0.25 2.25" />
                            <Vertex pos="-2 -0.25 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 2752 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2624 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -384 -1 0 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176775" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-91 25.25 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -91 0 1 0 25.25 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.249998 -1.75" />
                            <Vertex pos="2 0.249998 -2.25" />
                            <Vertex pos="2 -0.249998 -1.75" />
                            <Vertex pos="2 -0.249998 -2.25" />
                            <Vertex pos="-2 0.249998 2.25" />
                            <Vertex pos="-2 0.249998 1.75" />
                            <Vertex pos="-2 -0.249998 2.25" />
                            <Vertex pos="-2 -0.249998 1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 2752 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -2624 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.249998" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.249998" album="" material="bm_edge_white" texgens="1 0 0 -384 -1 0 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -0.176775" album="" material="bm_edge_white" texgens="1 0 0 0 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -0.176775" album="" material="bm_edge_white" texgens="-1 0 0 128 0 -1 0 -2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-81 53.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 53.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 -0.25 0.25" />
                            <Vertex pos="2.5 -0.25 -0.25" />
                            <Vertex pos="-2.5 0.25 0.25" />
                            <Vertex pos="-2.5 0.25 -0.25" />
                            <Vertex pos="-2.5 -0.25 0.25" />
                            <Vertex pos="-2.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_edge_white" texgens="0 1 0 1344 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_edge_white" texgens="0 -1 0 -1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 896 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 -1216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="-81 -0.625 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -0.625 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 0.125 0.25" />
                            <Vertex pos="2.5 0.125 -0.25" />
                            <Vertex pos="2.5 -0.125 0.25" />
                            <Vertex pos="2.5 -0.125 -0.25" />
                            <Vertex pos="-2.5 0.125 0.25" />
                            <Vertex pos="-2.5 0.125 -0.25" />
                            <Vertex pos="-2.5 -0.125 0.25" />
                            <Vertex pos="-2.5 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 1376 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 -1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 896 0 -1 0 -1248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 -768 0 -1 0 -1248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-2 2 -32" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 2 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="23" nextVertexID="41">
                        <Vertices>
                            <Vertex pos="17.119 5.56232 -12" />
                            <Vertex pos="17.119 5.56232 12" />
                            <Vertex pos="18 -4.51803e-005 -12" />
                            <Vertex pos="18 -4.51803e-005 12" />
                            <Vertex pos="14.5623 10.5801 -12" />
                            <Vertex pos="14.5623 10.5801 12" />
                            <Vertex pos="10.5801 14.5623 -12" />
                            <Vertex pos="10.5801 14.5623 12" />
                            <Vertex pos="5.56225 17.119 -12" />
                            <Vertex pos="5.56225 17.119 12" />
                            <Vertex pos="-5.05447e-005 18 -12" />
                            <Vertex pos="-5.05447e-005 18 12" />
                            <Vertex pos="-5.56233 17.119 -12" />
                            <Vertex pos="-5.56233 17.119 12" />
                            <Vertex pos="-10.5801 14.5624 -12" />
                            <Vertex pos="-10.5801 14.5624 12" />
                            <Vertex pos="-14.5623 10.5802 -12" />
                            <Vertex pos="-14.5623 10.5802 12" />
                            <Vertex pos="-17.119 5.56234 -12" />
                            <Vertex pos="-17.119 5.56234 12" />
                            <Vertex pos="-18 2.98023e-005 -12" />
                            <Vertex pos="-18 2.98023e-005 12" />
                            <Vertex pos="-17.119 -5.56225 -12" />
                            <Vertex pos="-17.119 -5.56225 12" />
                            <Vertex pos="-14.5623 -10.5801 -12" />
                            <Vertex pos="-14.5623 -10.5801 12" />
                            <Vertex pos="-10.5801 -14.5623 -12" />
                            <Vertex pos="-10.5801 -14.5623 12" />
                            <Vertex pos="-5.56231 -17.119 -12" />
                            <Vertex pos="-5.56231 -17.119 12" />
                            <Vertex pos="1.34706e-005 -18 -12" />
                            <Vertex pos="1.34706e-005 -18 12" />
                            <Vertex pos="5.56235 -17.119 -12" />
                            <Vertex pos="5.56235 -17.119 12" />
                            <Vertex pos="10.5802 -14.5623 -12" />
                            <Vertex pos="10.5802 -14.5623 12" />
                            <Vertex pos="14.5623 -10.5801 -12" />
                            <Vertex pos="14.5623 -10.5801 12" />
                            <Vertex pos="17.119 -5.56224 -12" />
                            <Vertex pos="17.119 -5.56224 12" />
                        </Vertices>
                        <Face id="0" plane="0.987688 0.156436 0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.156438 0.987688 0 0.00566101 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.891006 0.453991 -0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.453991 0.891006 0 0.00483704 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.707107 0.707107 0 0.00128174 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.453988 0.891008 -0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.891008 0.453988 0 0.00259399 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.156438 0.987688 -0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.987688 0.156437 0 -0.00746155 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.156437 0.987688 0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.987688 -0.156437 0 -0.00392151 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.453977 0.891013 0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.891011 -0.453983 0 -0.00743103 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.707107 0.707107 0 -17.7785" album="" material="bm_grid_blank4" texgens="-0.707107 -0.707107 0 0 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.89101 0.453984 0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.453988 -0.891008 0 0.0156937 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.987688 0.156437 0 -17.7784" album="" material="bm_grid_blank4" texgens="-0.156437 -0.987688 0 0 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.987688 -0.156438 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.156437 -0.987688 0 0.0154572 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.891008 -0.453988 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.453989 -0.891007 0 0.000411987 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.707107 -0.707107 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.707107 -0.707107 0 0.000579834 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.453991 -0.891006 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.891006 -0.453991 0 0.000289917 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.156437 -0.987688 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.987688 -0.156437 0 0.000457764 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.156437 -0.987688 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.987688 0.156437 0 0 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="0.453986 -0.891009 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.891009 0.453986 0 -0.0153961 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="0.707115 -0.707098 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.707098 0.707116 0 0.0153897 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="0.891009 -0.453986 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.453986 0.891009 0 0.00775909 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="0.987687 -0.15644 0 -17.7784" album="" material="bm_grid_blank4" texgens="0.156439 0.987688 0 -0.00428772 0 0 -1 1536 0 0.35198 0.25" texRot="0" texScale="0.35198 0.25" texDiv="256 256">
                            <Indices indices=" 39 3 2 38" />
                        </Face>
                        <Face id="20" plane="-0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2048 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 38 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36" />
                        </Face>
                        <Face id="21" plane="0 -0 1 -12" album="" material="bm_friction_grass" texgens="1 0 0 -1792 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="32 -50 -30" rot="1 0 0 0" scale="" transform="1 0 0 32 0 1 0 -50 0 0 1 -30 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="12.9344 5.35749 -14" />
                            <Vertex pos="12.9344 5.35749 14" />
                            <Vertex pos="14 -3.8147e-006 -14" />
                            <Vertex pos="14 -3.8147e-006 14" />
                            <Vertex pos="9.89937 9.89938 -14" />
                            <Vertex pos="9.89937 9.89938 14" />
                            <Vertex pos="5.35751 12.9344 -14" />
                            <Vertex pos="5.35751 12.9344 14" />
                            <Vertex pos="-9.53674e-006 14 -14" />
                            <Vertex pos="-9.53674e-006 14 14" />
                            <Vertex pos="-5.35766 12.9344 -14" />
                            <Vertex pos="-5.35766 12.9344 14" />
                            <Vertex pos="-9.8994 9.8997 -14" />
                            <Vertex pos="-9.8994 9.8997 14" />
                            <Vertex pos="-12.9343 5.35748 -14" />
                            <Vertex pos="-12.9343 5.35748 14" />
                            <Vertex pos="-14 1.14441e-005 -14" />
                            <Vertex pos="-14 1.14441e-005 14" />
                            <Vertex pos="-12.9343 -5.35749 -14" />
                            <Vertex pos="-12.9343 -5.35749 14" />
                            <Vertex pos="-9.89949 -9.89939 -14" />
                            <Vertex pos="-9.89949 -9.89939 14" />
                            <Vertex pos="-5.35757 -12.9344 -14" />
                            <Vertex pos="-5.35757 -12.9344 14" />
                            <Vertex pos="3.8147e-006 -14 -14" />
                            <Vertex pos="3.8147e-006 -14 14" />
                            <Vertex pos="5.35746 -12.9344 -14" />
                            <Vertex pos="5.35746 -12.9344 14" />
                            <Vertex pos="9.89938 -9.89936 -14" />
                            <Vertex pos="9.89938 -9.89936 14" />
                            <Vertex pos="12.9344 -5.35747 -14" />
                            <Vertex pos="12.9344 -5.35747 14" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195081 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.195093 0.980785 0 -0.00830078 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831451 0.555598 -0 -13.7309" album="" material="bm_grid_blank4" texgens="-0.555569 0.831471 0 0.00195313 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555597 0.831452 -0 -13.7309" album="" material="bm_grid_blank4" texgens="-0.831472 0.555566 0 0.00439453 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195082 0.980787 -0 -13.731" album="" material="bm_grid_blank4" texgens="-0.980785 0.195092 0 -0.00585938 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195076 0.980788 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.980785 -0.195092 0 0.0020752 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555569 0.831471 0 -13.7311" album="" material="bm_grid_blank4" texgens="-0.831468 -0.555572 0 0.00743103 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831477 0.555559 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.555574 -0.831467 0 0.00390625 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980785 0.195093 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.195092 -0.980785 0 -0.00463867 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980785 -0.195093 0 -13.731" album="" material="bm_grid_blank4" texgens="0.195092 -0.980785 0 0.000488281 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831467 -0.555574 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.555567 -0.831472 0 -0.00195313 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555592 -0.831455 0 -13.731" album="" material="bm_grid_blank4" texgens="0.831471 -0.555568 0 0.00341797 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195079 -0.980788 0 -13.731" album="" material="bm_grid_blank4" texgens="0.980785 -0.195092 0 0.00585938 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195081 -0.980787 0 -13.731" album="" material="bm_grid_blank4" texgens="0.980785 0.195092 0 -0.0020752 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555597 -0.831452 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.831469 0.555572 0 0.000259399 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831452 -0.555597 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.555564 0.831474 0 -0.00537109 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980787 -0.195082 0 -13.731" album="" material="bm_grid_blank4" texgens="0.195094 0.980785 0 0.000488281 0 0 -1 2816 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="-6.32876e-007 6.32877e-007 1 -14" album="" material="bm_friction_grass" texgens="1 0 0 -1280 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-83 31.5 -32" rot="1 0 0 0" scale="" transform="1 0 0 -83 0 1 0 31.5 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="27" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="23.1822 6.21151 -12" />
                            <Vertex pos="23.1822 6.21151 12" />
                            <Vertex pos="24 1.14441e-005 -12" />
                            <Vertex pos="24 1.14441e-005 12" />
                            <Vertex pos="20.7847 12 -12" />
                            <Vertex pos="20.7847 12 12" />
                            <Vertex pos="16.9706 16.9706 -12" />
                            <Vertex pos="16.9706 16.9706 12" />
                            <Vertex pos="12 20.7847 -12" />
                            <Vertex pos="12 20.7847 12" />
                            <Vertex pos="6.21158 23.1822 -12" />
                            <Vertex pos="6.21158 23.1822 12" />
                            <Vertex pos="-2.28882e-005 24 -12" />
                            <Vertex pos="-2.28882e-005 24 12" />
                            <Vertex pos="-6.21186 23.1822 -12" />
                            <Vertex pos="-6.21186 23.1822 12" />
                            <Vertex pos="-12 20.7847 -12" />
                            <Vertex pos="-12 20.7847 12" />
                            <Vertex pos="-16.9706 16.9706 -12" />
                            <Vertex pos="-16.9706 16.9706 12" />
                            <Vertex pos="-20.7847 12 -12" />
                            <Vertex pos="-20.7847 12 12" />
                            <Vertex pos="-23.1822 6.21185 -12" />
                            <Vertex pos="-23.1822 6.21185 12" />
                            <Vertex pos="-24 -4.00543e-005 -12" />
                            <Vertex pos="-24 -4.00543e-005 12" />
                            <Vertex pos="-23.1822 -6.2118 -12" />
                            <Vertex pos="-23.1822 -6.2118 12" />
                            <Vertex pos="-20.7847 -11.9999 -12" />
                            <Vertex pos="-20.7847 -11.9999 12" />
                            <Vertex pos="-16.9706 -16.9705 -12" />
                            <Vertex pos="-16.9706 -16.9705 12" />
                            <Vertex pos="-12 -20.7846 -12" />
                            <Vertex pos="-12 -20.7846 12" />
                            <Vertex pos="-6.21156 -23.1822 -12" />
                            <Vertex pos="-6.21156 -23.1822 12" />
                            <Vertex pos="0 -24 -12" />
                            <Vertex pos="0 -24 12" />
                            <Vertex pos="6.21156 -23.1822 -12" />
                            <Vertex pos="6.21156 -23.1822 12" />
                            <Vertex pos="12 -20.7846 -12" />
                            <Vertex pos="12 -20.7846 12" />
                            <Vertex pos="16.9706 -16.9705 -12" />
                            <Vertex pos="16.9706 -16.9705 12" />
                            <Vertex pos="20.7847 -11.9998 -12" />
                            <Vertex pos="20.7847 -11.9998 12" />
                            <Vertex pos="23.1822 -6.21156 -12" />
                            <Vertex pos="23.1822 -6.21156 12" />
                        </Vertices>
                        <Face id="0" plane="0.991444 0.130534 0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.13053 0.991444 0 -0.00195313 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.923888 0.382663 -0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.382682 0.92388 0 0 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.793356 0.608758 -0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.608754 0.793359 0 -0.00390625 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.608758 0.793356 -0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.79336 0.608753 0 0.0078125 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="0.382663 0.923888 -0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.923882 0.382678 0 -0.00439453 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="0.130533 0.991444 -0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.991444 0.130529 0 -0.00488281 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.130527 0.991445 0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.991444 -0.130529 0 -0.000488281 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.382681 0.92388 0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.923881 -0.38268 0 -0.00585938 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.608758 0.793356 0 -23.7948" album="" material="bm_grid_blank4" texgens="-0.793352 -0.608763 0 0.00195313 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.793356 0.608759 0 -23.7948" album="" material="bm_grid_blank4" texgens="-0.608772 -0.793346 0 0.00512695 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.923881 0.38268 0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.382681 -0.923881 0 0.0118103 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.991445 0.130526 0 -23.7947" album="" material="bm_grid_blank4" texgens="-0.130529 -0.991444 0 -0.000854492 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="-0.991445 -0.130528 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.130529 -0.991444 0 -0.000244141 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="-0.923879 -0.382686 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.382679 -0.923881 0 -0.00439453 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="-0.79336 -0.608753 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.608754 -0.793359 0 0.00390625 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="-0.608758 -0.793356 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.79336 -0.608753 0 -0.0078125 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="-0.38268 -0.923881 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.92388 -0.382682 0 -0.00146484 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="-0.130528 -0.991445 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.991444 -0.130529 0 0.00488281 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="0.130528 -0.991445 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.991445 0.130529 0 0.00439453 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="0.38268 -0.923881 0 -23.7946" album="" material="bm_grid_blank4" texgens="0.923879 0.382684 0 -0.00244141 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="0.608764 -0.793351 0 -23.7946" album="" material="bm_grid_blank4" texgens="0.793352 0.608764 0 0.00390625 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="0.793356 -0.608758 0 -23.7947" album="" material="bm_grid_blank4" texgens="0.608764 0.793351 0 0.00219727 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="0.923884 -0.382672 0 -23.7946" album="" material="bm_grid_blank4" texgens="0.382669 0.923886 0 0.0153809 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="0.991444 -0.130534 0 -23.7946" album="" material="bm_grid_blank4" texgens="0.130531 0.991444 0 -0.00195313 0 0 -1 1536 0 0.391578 0.25" texRot="0" texScale="0.391578 0.25" texDiv="256 256">
                            <Indices indices=" 47 3 2 46" />
                        </Face>
                        <Face id="24" plane="-0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -2816 0 -1 0 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 46 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44" />
                        </Face>
                        <Face id="25" plane="-2.01982e-006 1.16613e-006 1 -11.9999" album="" material="bm_friction_grass" texgens="1 0 0 -2560 0 -1 0 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-16.5 -32.75 -4" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -32.75 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.25 1" />
                            <Vertex pos="4 0.25 -1" />
                            <Vertex pos="4 -0.25 1" />
                            <Vertex pos="4 -0.25 -1" />
                            <Vertex pos="-4 0.25 1" />
                            <Vertex pos="-4 0.25 -1" />
                            <Vertex pos="-4 -0.25 1" />
                            <Vertex pos="-4 -0.25 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_grid_blank2" texgens="1 0 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_edge_white" texgens="1 0 0 -2432 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_edge_white" texgens="-1 0 0 2560 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-44.5 -28.5 -34" rot="1 0 0 0" scale="" transform="1 0 0 -44.5 0 1 0 -28.5 0 0 1 -34 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="12.9344 5.35748 -10" />
                            <Vertex pos="12.9344 5.35748 10" />
                            <Vertex pos="14 1.14441e-005 -10" />
                            <Vertex pos="14 1.14441e-005 10" />
                            <Vertex pos="9.89938 9.89934 -10" />
                            <Vertex pos="9.89938 9.89934 10" />
                            <Vertex pos="5.35749 12.9344 -10" />
                            <Vertex pos="5.35749 12.9344 10" />
                            <Vertex pos="3.8147e-006 14 -10" />
                            <Vertex pos="3.8147e-006 14 10" />
                            <Vertex pos="-5.3575 12.9344 -10" />
                            <Vertex pos="-5.3575 12.9344 10" />
                            <Vertex pos="-9.89937 9.89972 -10" />
                            <Vertex pos="-9.89937 9.89972 10" />
                            <Vertex pos="-12.9344 5.35747 -10" />
                            <Vertex pos="-12.9344 5.35747 10" />
                            <Vertex pos="-14 -3.24249e-005 -10" />
                            <Vertex pos="-14 -3.24249e-005 10" />
                            <Vertex pos="-12.9344 -5.35752 -10" />
                            <Vertex pos="-12.9344 -5.35752 10" />
                            <Vertex pos="-9.89939 -9.89938 -10" />
                            <Vertex pos="-9.89939 -9.89938 10" />
                            <Vertex pos="-5.35751 -12.9344 -10" />
                            <Vertex pos="-5.35751 -12.9344 10" />
                            <Vertex pos="-1.14441e-005 -14 -10" />
                            <Vertex pos="-1.14441e-005 -14 10" />
                            <Vertex pos="5.35749 -12.9344 -10" />
                            <Vertex pos="5.35749 -12.9344 10" />
                            <Vertex pos="9.89938 -9.89937 -10" />
                            <Vertex pos="9.89938 -9.89937 10" />
                            <Vertex pos="12.9344 -5.3575 -10" />
                            <Vertex pos="12.9344 -5.3575 10" />
                        </Vertices>
                        <Face id="0" plane="0.980787 0.195083 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.195093 0.980785 0 -0.00439453 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831451 0.555598 -0 -13.7309" album="" material="bm_grid_blank4" texgens="-0.555569 0.831471 0 0.00219727 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555601 0.831449 -0 -13.7309" album="" material="bm_grid_blank4" texgens="-0.831472 0.555566 0 0.000976563 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195082 0.980787 -0 -13.731" album="" material="bm_grid_blank4" texgens="-0.980785 0.195092 0 -0.00805664 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195082 0.980787 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.980785 -0.195092 0 0.00488281 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555554 0.83148 0 -13.7311" album="" material="bm_grid_blank4" texgens="-0.831468 -0.555572 0 0.00341797 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831473 0.555566 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.555574 -0.831467 0 0.00732422 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980787 0.195082 0 -13.731" album="" material="bm_grid_blank4" texgens="-0.195092 -0.980785 0 -0.00830078 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980787 -0.195083 0 -13.731" album="" material="bm_grid_blank4" texgens="0.195092 -0.980785 0 0.000244141 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831452 -0.555597 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.555567 -0.831472 0 -0.00127411 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555598 -0.831451 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.831471 -0.555568 0 0.000732422 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195081 -0.980787 0 -13.731" album="" material="bm_grid_blank4" texgens="0.980785 -0.195092 0 0.00805664 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195082 -0.980787 0 -13.731" album="" material="bm_grid_blank4" texgens="0.980785 0.195092 0 -0.00488281 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555597 -0.831452 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.831469 0.555572 0 -0.000976563 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831452 -0.555597 0 -13.7309" album="" material="bm_grid_blank4" texgens="0.555564 0.831474 0 -0.00390625 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980787 -0.195082 0 -13.731" album="" material="bm_grid_blank4" texgens="0.195094 0.980785 0 -0.00146484 0 0 -1 3328 0 0.341408 0.25" texRot="0" texScale="0.341408 0.25" texDiv="256 256">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-1.78989e-006 3.56016e-007 -1 -9.99998" album="" material="bm_grid_blank4" texgens="-1 0 0 -1536 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="1.26576e-006 -1.26576e-006 1 -10" album="" material="bm_friction_grass" texgens="1 0 0 -1280 0 -1 0 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-44.5 -22.5 -12" rot="1 0 0 0" scale="" transform="1 0 0 -44.5 0 1 0 -22.5 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 2 12" />
                            <Vertex pos="7 2 -12" />
                            <Vertex pos="8 -2 12" />
                            <Vertex pos="8 -2 -12" />
                            <Vertex pos="-5 2 12" />
                            <Vertex pos="-5 2 -12" />
                            <Vertex pos="-8 -2 12" />
                            <Vertex pos="-8 -2 -12" />
                        </Vertices>
                        <Face id="0" plane="0.970142 0.242536 0 -7.27607" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.8 0.6 0 -5.2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="" material="bm_friction_grass" texgens="1 0 0 768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-58.5 -36.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -58.5 0 1 0 -36.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -3904 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 4032 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 4032 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-51.5 -35.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -51.5 0 1 0 -35.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.25 0.25" />
                            <Vertex pos="1 1.25 -0.25" />
                            <Vertex pos="1 0.749996 0.25" />
                            <Vertex pos="1 0.749996 -0.25" />
                            <Vertex pos="-1 -0.75 0.25" />
                            <Vertex pos="-1 -0.75 -0.25" />
                            <Vertex pos="-1 -1.25 0.25" />
                            <Vertex pos="-1 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3648 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3776 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 4352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.176779" album="" material="bm_edge_white" texgens="1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-37.5 -33.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -37.5 0 1 0 -33.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.25 0.25" />
                            <Vertex pos="1 1.25 -0.25" />
                            <Vertex pos="1 0.75 0.25" />
                            <Vertex pos="1 0.75 -0.25" />
                            <Vertex pos="-1 -0.75 0.25" />
                            <Vertex pos="-1 -0.75 -0.25" />
                            <Vertex pos="-1 -1.25 0.25" />
                            <Vertex pos="-1 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2624 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2752 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 4352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-44.5 -34.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -44.5 0 1 0 -34.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-30.5 -32.75 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -32.75 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-30.5 -26.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -26.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-23.5 -25.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -25.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.25 0.25" />
                            <Vertex pos="1 1.25 -0.25" />
                            <Vertex pos="1 0.75 0.25" />
                            <Vertex pos="1 0.75 -0.25" />
                            <Vertex pos="-1 -0.749998 0.25" />
                            <Vertex pos="-1 -0.749998 -0.25" />
                            <Vertex pos="-1 -1.25 0.25" />
                            <Vertex pos="-1 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2624 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 2752 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 4352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 -1 0 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 -1 0 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-16.5 -24.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -24.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-9.5 -25.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.5 0 1 0 -25.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -0.75 0.25" />
                            <Vertex pos="1 -0.75 -0.25" />
                            <Vertex pos="1 -1.25 0.25" />
                            <Vertex pos="1 -1.25 -0.25" />
                            <Vertex pos="-1 1.25 0.25" />
                            <Vertex pos="-1 1.25 -0.25" />
                            <Vertex pos="-1 0.75 0.25" />
                            <Vertex pos="-1 0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3264 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 4352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -0.176777" album="" material="bm_edge_white" texgens="1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 -1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 -1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="0.5 -26.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -26.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="9 -0.25 0.25" />
                            <Vertex pos="9 -0.25 -0.25" />
                            <Vertex pos="-9 0.25 0.25" />
                            <Vertex pos="-9 0.25 -0.25" />
                            <Vertex pos="-9 -0.25 0.25" />
                            <Vertex pos="-9 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2176 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 2304 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-15 -33.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -33.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4.25" />
                            <Vertex pos="0.5 0.5 -4.25" />
                            <Vertex pos="0.5 -0.5 4.25" />
                            <Vertex pos="0.5 -0.5 -3.25" />
                            <Vertex pos="-0.5 0.5 4.25" />
                            <Vertex pos="-0.5 0.5 -4.25" />
                            <Vertex pos="-0.5 -0.5 4.25" />
                            <Vertex pos="-0.5 -0.5 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707106 -0.707107 -2.65165" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-18 -33.5 -0.25" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -33.5 0 0 1 -0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4.25" />
                            <Vertex pos="0.5 0.5 -4.25" />
                            <Vertex pos="0.5 -0.5 4.25" />
                            <Vertex pos="0.5 -0.5 -3.25" />
                            <Vertex pos="-0.5 0.5 4.25" />
                            <Vertex pos="-0.5 0.5 -4.25" />
                            <Vertex pos="-0.5 -0.5 4.25" />
                            <Vertex pos="-0.5 -0.5 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4.25" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707106 -0.707107 -2.65165" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-44.5 -34.75 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 -44.5 0 1 0 -34.75 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -2.65165" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -2.65165" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-16 -24.25 -5.75" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -24.25 0 0 1 -5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 0.25 0.25" />
                            <Vertex pos="4 0.25 -0.25" />
                            <Vertex pos="3.5 -0.25 0.25" />
                            <Vertex pos="4 -0.25 -0.25" />
                            <Vertex pos="-3.5 0.25 0.25" />
                            <Vertex pos="-4 0.25 -0.25" />
                            <Vertex pos="-3.5 -0.25 0.25" />
                            <Vertex pos="-4 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0 0.707107 -2.65165" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -2.65165" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -2944 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 3072 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-51.5 -29.25 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 -51.5 0 1 0 -29.25 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.25 0.25" />
                            <Vertex pos="1 1.25 -0.25" />
                            <Vertex pos="1 0.749998 0.25" />
                            <Vertex pos="1 0.749998 -0.25" />
                            <Vertex pos="-1 -0.749998 0.25" />
                            <Vertex pos="-1 -0.749998 -0.25" />
                            <Vertex pos="-1 -1.25 0.25" />
                            <Vertex pos="-1 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -3648 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3776 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -0.176778" album="" material="bm_edge_white" texgens="-1 0 0 4352 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.176778" album="" material="bm_edge_white" texgens="1 0 0 -4224 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -128 1 -1 0 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -128 1 -1 0 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-41.5 -26.5 -17" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 -26.5 0 0 1 -17 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 7" />
                            <Vertex pos="4 2 -7" />
                            <Vertex pos="1 -2 5" />
                            <Vertex pos="1 -2 -7" />
                            <Vertex pos="-4 2 7" />
                            <Vertex pos="-4 2 -7" />
                            <Vertex pos="-3 -2 5" />
                            <Vertex pos="-3 -2 -7" />
                        </Vertices>
                        <Face id="0" plane="0.8 -0.6 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 -0.242536 0 -3.3955" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 896 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -5.36656" album="" material="bm_friction_grass" texgens="1 0 0 1152 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-45 -25.5 -20" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -25.5 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 1 4" />
                            <Vertex pos="3.5 1 -4" />
                            <Vertex pos="-3.8147e-006 -1 3" />
                            <Vertex pos="0 -1 -4" />
                            <Vertex pos="-3.5 1 4" />
                            <Vertex pos="-3.5 1 -4" />
                            <Vertex pos="-2 -1 3" />
                            <Vertex pos="-2 -1 -4" />
                        </Vertices>
                        <Face id="0" plane="0.496139 -0.868243 2.70374e-007 -0.868242" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.8 -0.6 0 -2.2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 448 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -3.1305" album="" material="bm_friction_grass" texgens="1 0 0 1216 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 -704 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="0 0 -2" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 2" />
                            <Vertex pos="0.5 0.5 -2" />
                            <Vertex pos="0.5 -0.5 2" />
                            <Vertex pos="0.5 -0.5 -2" />
                            <Vertex pos="-0.5 0.5 2" />
                            <Vertex pos="-0.5 0.5 -2" />
                            <Vertex pos="-0.5 -0.5 2" />
                            <Vertex pos="-0.5 -0.5 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-14 0 0" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 0 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 4" />
                            <Vertex pos="0.5 0.5 -4" />
                            <Vertex pos="0.5 -0.5 4" />
                            <Vertex pos="0.5 -0.5 -4" />
                            <Vertex pos="-0.5 0.5 4" />
                            <Vertex pos="-0.5 0.5 -4" />
                            <Vertex pos="-0.5 -0.5 4" />
                            <Vertex pos="-0.5 -0.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="0 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -5" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -5" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -5" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-14 0 -15" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 0 0 0 1 -15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5" />
                            <Vertex pos="0.5 0.5 -5" />
                            <Vertex pos="0.5 -0.5 5" />
                            <Vertex pos="0.5 -0.5 -5" />
                            <Vertex pos="-0.5 0.5 5" />
                            <Vertex pos="-0.5 0.5 -5" />
                            <Vertex pos="-0.5 -0.5 5" />
                            <Vertex pos="-0.5 -0.5 -5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-7 0 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 0 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.375 0.5" />
                            <Vertex pos="1.5 0.375 -0.5" />
                            <Vertex pos="1.5 -0.375 0.5" />
                            <Vertex pos="1.5 -0.375 -0.5" />
                            <Vertex pos="-1.5 0.375 0.5" />
                            <Vertex pos="-1.5 0.375 -0.5" />
                            <Vertex pos="-1.5 -0.375 0.5" />
                            <Vertex pos="-1.5 -0.375 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.375" album="" material="bm_beam" texgens="0 0 -1 128 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.375" album="" material="bm_beam" texgens="0 0 -1 128 -1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 384 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 384 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="36 -48.5 -6.25" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 -48.5 0 0 1 -6.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 9.75" />
                            <Vertex pos="0.5 0.5 -9.75" />
                            <Vertex pos="0.5 -0.5 9.75" />
                            <Vertex pos="0.5 -0.5 -9.75" />
                            <Vertex pos="-0.5 0.5 9.75" />
                            <Vertex pos="-0.5 0.5 -9.75" />
                            <Vertex pos="-0.5 -0.5 9.75" />
                            <Vertex pos="-0.5 -0.5 -9.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -9.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="36 -39.5 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 -39.5 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 8.75" />
                            <Vertex pos="0.5 0.5 -8.75" />
                            <Vertex pos="0.5 -0.5 8.75" />
                            <Vertex pos="0.5 -0.5 -8.75" />
                            <Vertex pos="-0.5 0.5 8.75" />
                            <Vertex pos="-0.5 0.5 -8.75" />
                            <Vertex pos="-0.5 -0.5 8.75" />
                            <Vertex pos="-0.5 -0.5 -8.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-56.5 20.9375 3" rot="1 0 0 0" scale="" transform="1 0 0 -56.5 0 1 0 20.9375 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1.43751 0.5" />
                            <Vertex pos="0.5 1.43751 -0.5" />
                            <Vertex pos="0.5 -0.437506 0.5" />
                            <Vertex pos="0.5 -0.437506 -0.5" />
                            <Vertex pos="-0.5 0.687506 0.5" />
                            <Vertex pos="-0.5 0.687506 -0.5" />
                            <Vertex pos="-0.5 -1.43751 0.5" />
                            <Vertex pos="-0.5 -1.43751 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.6 0.8 0 -0.850005" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -0.662917" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-8.41473e-008 1.12196e-007 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-53 20 3" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 20 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.5" />
                            <Vertex pos="3 0.5 -0.5" />
                            <Vertex pos="4 -0.5 0.5" />
                            <Vertex pos="4 -0.5 -0.5" />
                            <Vertex pos="-3 0.5 0.5" />
                            <Vertex pos="-3 0.5 -0.5" />
                            <Vertex pos="-4 -0.5 0.5" />
                            <Vertex pos="-4 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.47488" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.47487" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-49.5 23.5 3" rot="1 0 0 0" scale="" transform="1 0 0 -49.5 0 1 0 23.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 3.99999 0.5" />
                            <Vertex pos="0.5 3.99999 -0.5" />
                            <Vertex pos="0.5 -3.99999 0.5" />
                            <Vertex pos="0.5 -3.99999 -0.5" />
                            <Vertex pos="-0.5 2.99999 0.5" />
                            <Vertex pos="-0.5 2.99999 -0.5" />
                            <Vertex pos="-0.5 -2.99999 0.5" />
                            <Vertex pos="-0.5 -2.99999 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.47487" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.47487" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-53 27 3" rot="1 0 0 0" scale="" transform="1 0 0 -53 0 1 0 27 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 0.5" />
                            <Vertex pos="4 0.5 -0.5" />
                            <Vertex pos="3 -0.5 0.5" />
                            <Vertex pos="3 -0.5 -0.5" />
                            <Vertex pos="-4 0.5 0.5" />
                            <Vertex pos="-4 0.5 -0.5" />
                            <Vertex pos="-3 -0.5 0.5" />
                            <Vertex pos="-3 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.47487" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.47488" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-56.5 26.0625 3" rot="1 0 0 0" scale="" transform="1 0 0 -56.5 0 1 0 26.0625 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.437496 0.5" />
                            <Vertex pos="0.5 0.437496 -0.5" />
                            <Vertex pos="0.5 -1.4375 0.5" />
                            <Vertex pos="0.5 -1.4375 -0.5" />
                            <Vertex pos="-0.5 1.4375 0.5" />
                            <Vertex pos="-0.5 1.4375 -0.5" />
                            <Vertex pos="-0.5 -0.687498 0.5" />
                            <Vertex pos="-0.5 -0.687498 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -0.66291" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.6 -0.8 -0 -0.849998" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-1.12197e-007 -1.12197e-007 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-56.5 25 3" rot="1 0 0 0" scale="" transform="1 0 0 -56.5 0 1 0 25 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.5 0.374998 0.5" />
                            <Vertex pos="-0.5 0.374998 -0.5" />
                            <Vertex pos="0.499996 -0.375 0.5" />
                            <Vertex pos="0.499996 -0.375 -0.5" />
                            <Vertex pos="-0.5 -0.375 0.5" />
                            <Vertex pos="-0.5 -0.375 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.600001 0.8 0 1.90735e-006" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.375" album="" material="bm_beam" texgens="0 0 -1 128.001 -1 0 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 2 3" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128.018 1 0 0 1664 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 1" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-56.5 22 3" rot="1 0 0 0" scale="" transform="1 0 0 -56.5 0 1 0 22 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.5 -0.374998 0.5" />
                            <Vertex pos="-0.5 -0.374998 -0.5" />
                            <Vertex pos="0.499996 0.375 0.5" />
                            <Vertex pos="0.499996 0.375 -0.5" />
                            <Vertex pos="-0.5 0.375 0.5" />
                            <Vertex pos="-0.5 0.375 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.600001 -0.8 0 1.90735e-006" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 -0 -0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.375" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128.018 1 0 0 1664 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-111 18 3" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 18 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.99999 0.5 0.5" />
                            <Vertex pos="4.99999 0.5 -0.5" />
                            <Vertex pos="5.99999 -0.5 0.5" />
                            <Vertex pos="5.99999 -0.5 -0.5" />
                            <Vertex pos="-5 0.5 0.5" />
                            <Vertex pos="-5 0.5 -0.5" />
                            <Vertex pos="-6 -0.5 0.5" />
                            <Vertex pos="-6 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.88908" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="0 0 -1 127.998 1 0 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-105.5 19.9375 3" rot="1 0 0 0" scale="" transform="1 0 0 -105.5 0 1 0 19.9375 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1.68749 0.5" />
                            <Vertex pos="0.5 1.68749 -0.5" />
                            <Vertex pos="0.5 -2.43749 0.5" />
                            <Vertex pos="0.5 -2.43749 -0.5" />
                            <Vertex pos="-0.5 2.43749 0.5" />
                            <Vertex pos="-0.5 2.43749 -0.5" />
                            <Vertex pos="-0.5 -1.43749 0.5" />
                            <Vertex pos="-0.5 -1.43749 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.6 0.8 -0 -1.64999" album="" material="bm_beam" texgens="0 0 -1 127.998 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.37001" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="4.61457e-008 6.15277e-008 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-111 29 3" rot="1 0 0 0" scale="" transform="1 0 0 -111 0 1 0 29 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.5 0.5" />
                            <Vertex pos="6 0.5 -0.5" />
                            <Vertex pos="5 -0.5 0.5" />
                            <Vertex pos="5 -0.5 -0.5" />
                            <Vertex pos="-6.00001 0.5 0.5" />
                            <Vertex pos="-6.00001 0.5 -0.5" />
                            <Vertex pos="-5.00001 -0.5 0.5" />
                            <Vertex pos="-5.00001 -0.5 -0.5" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -3.88909" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.88909" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="0 0 -1 127.998 1 0 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 1 0 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-105.5 27.0625 3" rot="1 0 0 0" scale="" transform="1 0 0 -105.5 0 1 0 27.0625 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2.43749 0.5" />
                            <Vertex pos="0.5 2.43749 -0.5" />
                            <Vertex pos="0.5 -1.68749 0.5" />
                            <Vertex pos="0.5 -1.68749 -0.5" />
                            <Vertex pos="-0.5 1.43749 0.5" />
                            <Vertex pos="-0.5 1.43749 -0.5" />
                            <Vertex pos="-0.5 -2.43749 0.5" />
                            <Vertex pos="-0.5 -2.43749 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 -400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -1.37001" album="" material="bm_beam" texgens="0 0 -1 127.998 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.6 -0.8 0 -1.64999" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="6.15278e-008 -6.15278e-008 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-116.5 23.5 3" rot="1 0 0 0" scale="" transform="1 0 0 -116.5 0 1 0 23.5 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 5.00001 0.5" />
                            <Vertex pos="0.5 5.00001 -0.5" />
                            <Vertex pos="0.5 -5.00001 0.5" />
                            <Vertex pos="0.5 -5.00001 -0.5" />
                            <Vertex pos="-0.5 6.00001 0.5" />
                            <Vertex pos="-0.5 6.00001 -0.5" />
                            <Vertex pos="-0.5 -6.00001 0.5" />
                            <Vertex pos="-0.5 -6.00001 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -3.8891" album="" material="bm_beam" texgens="0 0 -1 127.998 1 0 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -3.8891" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-105.5 25 3" rot="1 0 0 0" scale="" transform="1 0 0 -105.5 0 1 0 25 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.500008 0.375006 0.5" />
                            <Vertex pos="0.500008 0.375006 -0.5" />
                            <Vertex pos="0.500008 -0.375004 0.5" />
                            <Vertex pos="0.500008 -0.375004 -0.5" />
                            <Vertex pos="-0.500008 -0.375004 0.5" />
                            <Vertex pos="-0.500008 -0.375004 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.500008" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.599999 0.800001 0 -7.45058e-007" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.375004" album="" material="bm_beam" texgens="0 0 -1 128.002 -1 0 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 2 3" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128.018 1 0 0 -1152 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 1" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-105.5 22 3" rot="1 0 0 0" scale="" transform="1 0 0 -105.5 0 1 0 22 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.5 -0.375004 0.5" />
                            <Vertex pos="0.5 -0.375004 -0.5" />
                            <Vertex pos="0.5 0.375004 0.5" />
                            <Vertex pos="0.5 0.375004 -0.5" />
                            <Vertex pos="-0.500008 0.375004 0.5" />
                            <Vertex pos="-0.500008 0.375004 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="" material="bm_beam" texgens="0 0 -1 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.600001 -0.799999 -0 -2.32458e-006" album="" material="bm_beam" texgens="0 0 -1 128 0 1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.375004" album="" material="bm_beam" texgens="0 0 -1 127.999 1 0 0 -1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 3 2 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1920 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 2 0" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.5" album="" material="bm_beam" texgens="0 -1 0 128.018 1 0 0 -1152 0 0.09375 0.125" texRot="0" texScale="0.09375 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-64.5 22 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -64.5 0 1 0 22 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 7.75" />
                            <Vertex pos="0.5 0.5 -7.75" />
                            <Vertex pos="0.5 -0.5 7.75" />
                            <Vertex pos="0.5 -0.5 -7.75" />
                            <Vertex pos="-0.5 0.5 7.75" />
                            <Vertex pos="-0.5 0.5 -7.75" />
                            <Vertex pos="-0.5 -0.5 7.75" />
                            <Vertex pos="-0.5 -0.5 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-64.5 25 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -64.5 0 1 0 25 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 7.75" />
                            <Vertex pos="0.5 0.5 -7.75" />
                            <Vertex pos="0.5 -0.5 7.75" />
                            <Vertex pos="0.5 -0.5 -7.75" />
                            <Vertex pos="-0.5 0.5 7.75" />
                            <Vertex pos="-0.5 0.5 -7.75" />
                            <Vertex pos="-0.5 -0.5 7.75" />
                            <Vertex pos="-0.5 -0.5 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-97.5 22 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -97.5 0 1 0 22 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 7.75" />
                            <Vertex pos="0.5 0.5 -7.75" />
                            <Vertex pos="0.5 -0.5 7.75" />
                            <Vertex pos="0.5 -0.5 -7.75" />
                            <Vertex pos="-0.5 0.5 7.75" />
                            <Vertex pos="-0.5 0.5 -7.75" />
                            <Vertex pos="-0.5 -0.5 7.75" />
                            <Vertex pos="-0.5 -0.5 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-97.5 25 -12.25" rot="1 0 0 0" scale="" transform="1 0 0 -97.5 0 1 0 25 0 0 1 -12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 7.75" />
                            <Vertex pos="0.5 0.5 -7.75" />
                            <Vertex pos="0.5 -0.5 7.75" />
                            <Vertex pos="0.5 -0.5 -7.75" />
                            <Vertex pos="-0.5 0.5 7.75" />
                            <Vertex pos="-0.5 0.5 -7.75" />
                            <Vertex pos="-0.5 -0.5 7.75" />
                            <Vertex pos="-0.5 -0.5 -7.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="38.5 -53 7.75" rot="1 0 0 0" scale="" transform="1 0 0 38.5 0 1 0 -53 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 -2 0.25" />
                            <Vertex pos="3 -2 -0.25" />
                            <Vertex pos="-3 2 0.25" />
                            <Vertex pos="-3 2 -0.25" />
                            <Vertex pos="-3 -2 0.25" />
                            <Vertex pos="-3 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 4992 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 -4864 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_sand" texgens="1 0 0 1792 0 -1 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 -2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="39.5 -50.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 39.5 0 1 0 -50.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 -0.5 0.25" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="-1 0.5 0.25" />
                            <Vertex pos="-1 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 4608 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -1.06066" album="" material="bm_edge_white" texgens="0 -1 0 -4480 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1792 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_sand" texgens="1 0 0 2048 0 -1 0 -4224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 -2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="40 -49.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 40 0 1 0 -49.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.5 0.25" />
                            <Vertex pos="1.5 0.5 -0.25" />
                            <Vertex pos="1.5 -0.5 0.25" />
                            <Vertex pos="1.5 -0.5 -0.25" />
                            <Vertex pos="-0.500004 0.5 0.25" />
                            <Vertex pos="-0.500004 0.5 -0.25" />
                            <Vertex pos="-1.5 -0.5 0.25" />
                            <Vertex pos="-1.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="" material="bm_edge_white" texgens="0 1 0 4608 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -0.707109" album="" material="bm_edge_white" texgens="0 -1 0 -4480 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_sand" texgens="1 0 0 2176 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 -832 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="37 -50.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 -50.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.5 0.25" />
                            <Vertex pos="1.5 0.5 -0.25" />
                            <Vertex pos="0.499996 -0.5 0.25" />
                            <Vertex pos="0.499996 -0.5 -0.25" />
                            <Vertex pos="-1.5 0.5 0.25" />
                            <Vertex pos="-1.5 0.5 -0.25" />
                            <Vertex pos="-1.5 -0.5 0.25" />
                            <Vertex pos="-1.5 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -0.707104" album="" material="bm_edge_white" texgens="0 1 0 4608 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="" material="bm_edge_white" texgens="0 -1 0 -4480 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 384 0 -1 0 -4224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 64 0 -1 0 -2112 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="37.5 -49.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 37.5 0 1 0 -49.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="0.999996 -0.5 0.25" />
                            <Vertex pos="0.999996 -0.5 -0.25" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 0.5 -0.25" />
                            <Vertex pos="-2 -0.5 0.25" />
                            <Vertex pos="-2 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.06066" album="" material="bm_edge_white" texgens="0 1 0 4608 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -4480 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 2176 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile10_B" texgens="1 0 0 512 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="41.75 -50 8" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -50 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0" />
                            <Vertex pos="0.25 1 -0.5" />
                            <Vertex pos="0.25 -1 0.5" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0" />
                            <Vertex pos="-0.25 1 -0.5" />
                            <Vertex pos="-0.25 -1 0.5" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242535" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="41.75 -53.25 8" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -53.25 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.5" />
                            <Vertex pos="0.25 2.25 -0.5" />
                            <Vertex pos="0.25 -2.25 0.5" />
                            <Vertex pos="0.25 -2.25 -0.5" />
                            <Vertex pos="-0.25 2.25 0.5" />
                            <Vertex pos="-0.25 2.25 -0.5" />
                            <Vertex pos="-0.25 -2.25 0.5" />
                            <Vertex pos="-0.25 -2.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 1088 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_edge_white" texgens="1 0 0 1088 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="" material="bm_edge_white" texgens="1 0 0 1088 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 -960 0 -1 0 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="40.5 -55.25 8" rot="1 0 0 0" scale="" transform="1 0 0 40.5 0 1 0 -55.25 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.5" />
                            <Vertex pos="1 0.25 -0.5" />
                            <Vertex pos="1 -0.25 0.5" />
                            <Vertex pos="1 -0.25 -0.5" />
                            <Vertex pos="-1 0.25 0" />
                            <Vertex pos="-1 0.25 -0.5" />
                            <Vertex pos="-1 -0.25 0" />
                            <Vertex pos="-1 -0.25 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 -2880 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_edge_white" texgens="0 -1 0 3008 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="" material="bm_edge_white" texgens="1 0 0 -256 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 384 0 -1 0 3008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-50 -34 -18.25" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 -34 0 0 1 -18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5.75" />
                            <Vertex pos="0.5 0.5 -5.75" />
                            <Vertex pos="0.5 -0.5 5.75" />
                            <Vertex pos="0.5 -0.5 -5.75" />
                            <Vertex pos="-0.5 0.5 5.75" />
                            <Vertex pos="-0.5 0.5 -5.75" />
                            <Vertex pos="-0.5 -0.5 5.75" />
                            <Vertex pos="-0.5 -0.5 -5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="-39 -34 -18.25" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -34 0 0 1 -18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 5.75" />
                            <Vertex pos="0.5 0.5 -5.75" />
                            <Vertex pos="0.5 -0.5 5.75" />
                            <Vertex pos="0.5 -0.5 -5.75" />
                            <Vertex pos="-0.5 0.5 5.75" />
                            <Vertex pos="-0.5 0.5 -5.75" />
                            <Vertex pos="-0.5 -0.5 5.75" />
                            <Vertex pos="-0.5 -0.5 -5.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_beam" texgens="-1 0 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_beam" texgens="1 0 0 128 0 0 -1 -1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5.75" album="" material="bm_beam" texgens="1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -5.75" album="" material="bm_beam" texgens="-1 0 0 128 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="-7 6 -1" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 6 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692906 0.286843 -19" />
                            <Vertex pos="0.692906 0.286843 19" />
                            <Vertex pos="0.75 -2.86102e-006 -19" />
                            <Vertex pos="0.75 -2.86102e-006 19" />
                            <Vertex pos="0.530312 0.530313 -19" />
                            <Vertex pos="0.530312 0.530313 19" />
                            <Vertex pos="0.286999 0.692812 -19" />
                            <Vertex pos="0.286999 0.692812 19" />
                            <Vertex pos="3.09944e-005 0.75 -19" />
                            <Vertex pos="3.09944e-005 0.75 19" />
                            <Vertex pos="-0.287096 0.692781 -19" />
                            <Vertex pos="-0.287096 0.692781 19" />
                            <Vertex pos="-0.530314 0.530313 -19" />
                            <Vertex pos="-0.530314 0.530313 19" />
                            <Vertex pos="-0.692906 0.286878 -19" />
                            <Vertex pos="-0.692906 0.286878 19" />
                            <Vertex pos="-0.75 1.90735e-006 -19" />
                            <Vertex pos="-0.75 1.90735e-006 19" />
                            <Vertex pos="-0.692906 -0.286877 -19" />
                            <Vertex pos="-0.692906 -0.286877 19" />
                            <Vertex pos="-0.530376 -0.530281 -19" />
                            <Vertex pos="-0.530376 -0.530281 19" />
                            <Vertex pos="-0.286968 -0.692813 -19" />
                            <Vertex pos="-0.286968 -0.692813 19" />
                            <Vertex pos="-9.53674e-007 -0.75 -19" />
                            <Vertex pos="-9.53674e-007 -0.75 19" />
                            <Vertex pos="0.286999 -0.692813 -19" />
                            <Vertex pos="0.286999 -0.692813 19" />
                            <Vertex pos="0.530346 -0.53031 -19" />
                            <Vertex pos="0.530346 -0.53031 19" />
                            <Vertex pos="0.692906 -0.286877 -19" />
                            <Vertex pos="0.692906 -0.286877 19" />
                        </Vertices>
                        <Face id="0" plane="0.980761 0.195211 0 -0.73557" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68385 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831606 0.555366 -0 -0.735528" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.044 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.55539 0.83159 -0 -0.735532" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4107 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195439 0.980716 -0 -0.735543" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7749 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195438 0.980716 0 -0.735531" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1393 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555464 0.831541 0 -0.735547" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5058 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831574 0.555414 0 -0.735539" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8666 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195191 0 -0.735574" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2359 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.19519 0 -0.735574" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5961 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831639 -0.555317 0 -0.735555" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9574 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555317 -0.831639 0 -0.735529" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3252 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195438 -0.980716 0 -0.735538" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.691 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195418 -0.98072 0 -0.73554" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555342 -0.831622 0 -0.735541" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831623 -0.555341 0 -0.735551" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980765 -0.195192 0 -0.735574" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.144 0 0 -1 -608 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-1.67028e-005 -3.32454e-006 -1 -19" album="" material="solid_bm" texgens="-1 0 0 0.499985 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="-3.30327e-005 3.77289e-005 1 -19" album="" material="solid_bm" texgens="1 0 0 0.500015 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="25 -44 5" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 -44 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.692909 0.286865 -21" />
                            <Vertex pos="0.692909 0.286865 21" />
                            <Vertex pos="0.75 7.62939e-006 -21" />
                            <Vertex pos="0.75 7.62939e-006 21" />
                            <Vertex pos="0.530304 0.530319 -21" />
                            <Vertex pos="0.530304 0.530319 21" />
                            <Vertex pos="0.287094 0.692814 -21" />
                            <Vertex pos="0.287094 0.692814 21" />
                            <Vertex pos="-5.34058e-005 0.75 -21" />
                            <Vertex pos="-5.34058e-005 0.75 21" />
                            <Vertex pos="-0.287123 0.69281 -21" />
                            <Vertex pos="-0.287123 0.69281 21" />
                            <Vertex pos="-0.530296 0.530296 -21" />
                            <Vertex pos="-0.530296 0.530296 21" />
                            <Vertex pos="-0.692902 0.286892 -21" />
                            <Vertex pos="-0.692902 0.286892 21" />
                            <Vertex pos="-0.75 -3.8147e-006 -21" />
                            <Vertex pos="-0.75 -3.8147e-006 21" />
                            <Vertex pos="-0.692905 -0.286884 -21" />
                            <Vertex pos="-0.692905 -0.286884 21" />
                            <Vertex pos="-0.530373 -0.530323 -21" />
                            <Vertex pos="-0.530373 -0.530323 21" />
                            <Vertex pos="-0.286978 -0.692818 -21" />
                            <Vertex pos="-0.286978 -0.692818 21" />
                            <Vertex pos="4.3869e-005 -0.75 -21" />
                            <Vertex pos="4.3869e-005 -0.75 21" />
                            <Vertex pos="0.287037 -0.69281 -21" />
                            <Vertex pos="0.287037 -0.69281 21" />
                            <Vertex pos="0.530348 -0.530308 -21" />
                            <Vertex pos="0.530348 -0.530308 21" />
                            <Vertex pos="0.692904 -0.286884 -21" />
                            <Vertex pos="0.692904 -0.286884 21" />
                        </Vertices>
                        <Face id="0" plane="0.980765 0.195193 0 -0.735575" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68213 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831573 0.555416 -0 -0.735534" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0455 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.55554 0.83149 -0 -0.73556" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.412 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195317 0.98074 -0 -0.735545" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7772 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195381 0.980727 0 -0.735556" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1395 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555642 0.831422 0 -0.735555" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5058 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831521 0.555494 0 -0.735529" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8665 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.980765 0.195193 0 -0.735573" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2316 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980765 -0.195191 0 -0.735575" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5977 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831671 -0.555268 0 -0.735567" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9562 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.555248 -0.831685 0 -0.73555" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3279 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195387 -0.980726 0 -0.735536" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.69 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.19543 -0.980718 0 -0.735547" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.055 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555398 -0.831585 0 -0.73555" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.421 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831619 -0.555347 0 -0.735552" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980766 -0.195189 0 -0.735573" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.143 0 0 -1 -672 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -21" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.499878 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="2.83003e-005 -1.88986e-005 1 -21" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.499878 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="-95 46 7" rot="1 0 0 0" scale="" transform="1 0 0 -95 0 1 0 46 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="19" nextVertexID="33">
                        <Vertices>
                            <Vertex pos="0.69281 0.286877 -27" />
                            <Vertex pos="0.69281 0.286877 27" />
                            <Vertex pos="0.75 -1.52588e-005 -27" />
                            <Vertex pos="0.75 -1.52588e-005 27" />
                            <Vertex pos="0.530304 0.530312 -27" />
                            <Vertex pos="0.530304 0.530312 27" />
                            <Vertex pos="0.286873 0.69281 -27" />
                            <Vertex pos="0.286873 0.69281 27" />
                            <Vertex pos="-2.28882e-005 0.750004 -27" />
                            <Vertex pos="-2.28882e-005 0.750004 27" />
                            <Vertex pos="-0.287193 0.692818 -27" />
                            <Vertex pos="-0.287193 0.692818 27" />
                            <Vertex pos="-0.530304 0.530327 -27" />
                            <Vertex pos="-0.530304 0.530327 27" />
                            <Vertex pos="-0.692818 0.286869 -27" />
                            <Vertex pos="-0.692818 0.286869 27" />
                            <Vertex pos="-0.750008 7.62939e-006 -27" />
                            <Vertex pos="-0.750008 7.62939e-006 27" />
                            <Vertex pos="-0.692818 -0.286877 -27" />
                            <Vertex pos="-0.692818 -0.286877 27" />
                            <Vertex pos="-0.530319 -0.530308 -27" />
                            <Vertex pos="-0.530319 -0.530308 27" />
                            <Vertex pos="-0.286865 -0.692818 -27" />
                            <Vertex pos="-0.286865 -0.692818 27" />
                            <Vertex pos="1.52588e-005 -0.750008 -27" />
                            <Vertex pos="1.52588e-005 -0.750008 27" />
                            <Vertex pos="0.286865 -0.692825 -27" />
                            <Vertex pos="0.286865 -0.692825 27" />
                            <Vertex pos="0.530304 -0.530323 -27" />
                            <Vertex pos="0.530304 -0.530323 27" />
                            <Vertex pos="0.692818 -0.286865 -27" />
                            <Vertex pos="0.692818 -0.286865 27" />
                        </Vertices>
                        <Face id="0" plane="0.980704 0.195497 0 -0.735525" album="" material="solid_bm" texgens="-0.195089 0.980786 0 4.68762 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0.831709 0.555211 -0 -0.735494" album="" material="solid_bm" texgens="-0.555572 0.831468 0 14.0396 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.555199 0.831717 -0 -0.735494" album="" material="solid_bm" texgens="-0.831471 0.555569 0 23.4097 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="0.195507 0.980702 -0 -0.735526" album="" material="solid_bm" texgens="-0.980786 0.195088 0 32.7791 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.195302 0.980743 0 -0.735566" album="" material="solid_bm" texgens="-0.980784 -0.195095 0 42.1433 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.555687 0.831391 0 -0.735592" album="" material="solid_bm" texgens="-0.831471 -0.555568 0 51.5059 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.831721 0.555193 0 -0.735499" album="" material="solid_bm" texgens="-0.555573 -0.831468 0 60.8668 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.9807 0.195517 0 -0.735534" album="" material="solid_bm" texgens="-0.195092 -0.980785 0 70.2361 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.980703 -0.195502 0 -0.735534" album="" material="solid_bm" texgens="0.195089 -0.980786 0 79.5923 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.831717 -0.555199 0 -0.735502" album="" material="solid_bm" texgens="0.555567 -0.831472 0 88.9595 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.55519 -0.831723 0 -0.735497" album="" material="solid_bm" texgens="0.831471 -0.555569 0 98.3206 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.195504 -0.980703 0 -0.735532" album="" material="solid_bm" texgens="0.980786 -0.195089 0 107.689 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.195499 -0.980704 0 -0.735538" album="" material="solid_bm" texgens="0.980785 0.195092 0 117.059 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.555196 -0.831719 0 -0.735503" album="" material="solid_bm" texgens="0.831468 0.555572 0 126.419 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.831721 -0.555193 0 -0.735497" album="" material="solid_bm" texgens="0.555569 0.83147 0 135.786 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.980704 -0.195499 0 -0.735531" album="" material="solid_bm" texgens="0.195087 0.980786 0 145.145 0 0 -1 -864 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 3 2 30" />
                        </Face>
                        <Face id="16" plane="-0 0 -1 -27" album="" material="solid_bm" texgens="-1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28" />
                        </Face>
                        <Face id="17" plane="-1.88658e-005 2.82622e-005 1 -27" album="" material="solid_bm" texgens="1 0 0 0.5 0 -1 0 0.5 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-81 -18 6.375" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -18 0 0 1 6.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 0.875" />
                            <Vertex pos="2 0.5 0.375" />
                            <Vertex pos="2 -0.5 -0.375" />
                            <Vertex pos="2 -0.5 -0.875" />
                            <Vertex pos="-2 0.5 0.875" />
                            <Vertex pos="-2 0.5 0.375" />
                            <Vertex pos="-2 -0.5 -0.375" />
                            <Vertex pos="-2 -0.5 -0.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.780869 0.624695 -0.156174" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.780869 -0.624695 -0.156174" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="-81 -17 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -81 0 1 0 -17 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 1" />
                            <Vertex pos="2 0.5 0.5" />
                            <Vertex pos="2 -0.5 -0.500001" />
                            <Vertex pos="2 -0.5 -1" />
                            <Vertex pos="-2 0.5 1" />
                            <Vertex pos="-2 0.5 0.5" />
                            <Vertex pos="-2 -0.5 -0.500001" />
                            <Vertex pos="-2 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.83205 0.5547 -0.138675" album="" material="bm_tile10_B" texgens="1 0 0 0 0 -1 0 2176 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.83205 -0.5547 -0.138675" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="-78.75 -18 6.375" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -18 0 0 1 6.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.875" />
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="0.25 -0.5 -0.875" />
                            <Vertex pos="-0.25 0.5 0.875" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 -0.5 -0.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 1.25 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.780869 0.624695 -0.156174" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.780869 -0.624695 -0.156174" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="-78.75 -17 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -78.75 0 1 0 -17 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 1" />
                            <Vertex pos="0.25 0.5 0.5" />
                            <Vertex pos="0.25 -0.5 -0.500001" />
                            <Vertex pos="0.25 -0.5 -1" />
                            <Vertex pos="-0.25 0.5 1" />
                            <Vertex pos="-0.25 0.5 0.5" />
                            <Vertex pos="-0.25 -0.5 -0.500001" />
                            <Vertex pos="-0.25 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 0 0 1.5 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 5120 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.83205 0.5547 -0.138675" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.83205 -0.5547 -0.138675" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="-83.25 -18 6.375" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -18 0 0 1 6.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 0.875" />
                            <Vertex pos="0.25 0.5 0.375" />
                            <Vertex pos="0.25 -0.5 -0.375" />
                            <Vertex pos="0.25 -0.5 -0.875" />
                            <Vertex pos="-0.25 0.5 0.875" />
                            <Vertex pos="-0.25 0.5 0.375" />
                            <Vertex pos="-0.25 -0.5 -0.375" />
                            <Vertex pos="-0.25 -0.5 -0.875" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 1.25 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.780869 0.624695 -0.156174" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.780869 -0.624695 -0.156174" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-83.25 -17 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -83.25 0 1 0 -17 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.5 1" />
                            <Vertex pos="0.25 0.5 0.5" />
                            <Vertex pos="0.25 -0.5 -0.500001" />
                            <Vertex pos="0.25 -0.5 -1" />
                            <Vertex pos="-0.25 0.5 1" />
                            <Vertex pos="-0.25 0.5 0.5" />
                            <Vertex pos="-0.25 -0.5 -0.500001" />
                            <Vertex pos="-0.25 -0.5 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -4992 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 0 0 1.5 -1 63.9999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.83205 0.5547 -0.138675" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.83205 -0.5547 -0.138675" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="4" type="4" pos="-111.25 22 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -111.25 0 1 0 22 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 2 0.25" />
                            <Vertex pos="0.75 2 -0.25" />
                            <Vertex pos="0.75 1 0.25" />
                            <Vertex pos="0.75 1 -0.25" />
                            <Vertex pos="-0.25 2 0.25" />
                            <Vertex pos="-0.25 2 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.75" album="" material="bm_edge_white" texgens="0 1 0 3200 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 1" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="8" type="4" pos="-52.75 23 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -52.75 0 1 0 23 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 0 0.25" />
                            <Vertex pos="0.25 0 -0.25" />
                            <Vertex pos="-0.75 1 0.25" />
                            <Vertex pos="-0.75 1 -0.25" />
                            <Vertex pos="-0.75 0 0.25" />
                            <Vertex pos="-0.75 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.75" album="" material="bm_edge_white" texgens="0 -1 0 -1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_edge_white" texgens="-1 0 0 576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 576 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
