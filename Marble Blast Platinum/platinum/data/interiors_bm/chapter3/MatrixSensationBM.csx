<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/02/24 16:39:25">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="12">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="12" dl="0" group="-1" locked="0" />
        <SceneShape id="9" type="1" entityID="14" dl="0" group="-1" locked="0" />
        <SceneShape id="10" type="1" entityID="15" dl="0" group="-1" locked="0" />
        <SceneShape id="11" type="1" entityID="16" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="17">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-8 0 0.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-8 0 10.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-8 0 0.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="8 0 10.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="8 0 0.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="8 0 10.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-21 -1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-21 1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="-21 -1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="21 1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="21 -1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="21 1 17.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="118">
                    <Brush id="0" owner="0" type="0" pos="0 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="0 4 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 4 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="0 -4 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="0 10 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 10 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="0 -10 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -10 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="0 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 14 6" />
                            <Vertex pos="2 14 -6" />
                            <Vertex pos="2 -14 6" />
                            <Vertex pos="2 -14 -6" />
                            <Vertex pos="-2 14 6" />
                            <Vertex pos="-2 14 -6" />
                            <Vertex pos="-2 -14 6" />
                            <Vertex pos="-2 -14 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -14" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-4 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 6" />
                            <Vertex pos="2 6 -6" />
                            <Vertex pos="2 -6 6" />
                            <Vertex pos="2 -6 -6" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-2 2 -6" />
                            <Vertex pos="-2 -2 6" />
                            <Vertex pos="-2 -2 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.82843" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="4 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 6" />
                            <Vertex pos="2 2 -6" />
                            <Vertex pos="2 -2 6" />
                            <Vertex pos="2 -2 -6" />
                            <Vertex pos="-2 6 6" />
                            <Vertex pos="-2 6 -6" />
                            <Vertex pos="-2 -6 6" />
                            <Vertex pos="-2 -6 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -2.82843" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -6" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="0 8 10.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="0 -8 10.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -8 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_trim" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="0 0 10.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="8 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-8 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="8 0 15" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.999998" />
                            <Vertex pos="2 2 -0.999999" />
                            <Vertex pos="2 -2 0.999998" />
                            <Vertex pos="2 -2 -0.999999" />
                            <Vertex pos="-2 2 0.999998" />
                            <Vertex pos="-2 2 9.53674e-007" />
                            <Vertex pos="-2 -2 0.999998" />
                            <Vertex pos="-2 -2 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.999998" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.48507" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="16 0 2" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 0 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 14" />
                            <Vertex pos="6 6 -14" />
                            <Vertex pos="6 -6 14" />
                            <Vertex pos="6 -6 -14" />
                            <Vertex pos="-6 6 14" />
                            <Vertex pos="-6 6 -14" />
                            <Vertex pos="-6 -6 14" />
                            <Vertex pos="-6 -6 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile08_A" texgens="1 0 0 1536 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="16 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.25" />
                            <Vertex pos="6 6 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-6 6 0.25" />
                            <Vertex pos="-6 6 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="16 0 20.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 0 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.25" />
                            <Vertex pos="6 6 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-6 6 0.25" />
                            <Vertex pos="-6 6 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-16 0 2" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 14" />
                            <Vertex pos="6 6 -14" />
                            <Vertex pos="6 -6 14" />
                            <Vertex pos="6 -6 -14" />
                            <Vertex pos="-6 6 14" />
                            <Vertex pos="-6 6 -14" />
                            <Vertex pos="-6 -6 14" />
                            <Vertex pos="-6 -6 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank2" texgens="1 0 0 512 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_tile08_A" texgens="1 0 0 1536 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-16 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.25" />
                            <Vertex pos="6 6 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-6 6 0.25" />
                            <Vertex pos="-6 6 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-16 0 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 0 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 0.25" />
                            <Vertex pos="6 6 -0.25" />
                            <Vertex pos="6 -6 0.25" />
                            <Vertex pos="6 -6 -0.25" />
                            <Vertex pos="-6 6 0.25" />
                            <Vertex pos="-6 6 -0.25" />
                            <Vertex pos="-6 -6 0.25" />
                            <Vertex pos="-6 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="0 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="0 -4 17.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 2 -1.75" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 2 -1.75" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="0 4 17.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 4 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 -2 -1.25" />
                            <Vertex pos="2 -2 -1.75" />
                            <Vertex pos="-2 2 1.75" />
                            <Vertex pos="-2 2 1.25" />
                            <Vertex pos="-2 -2 -1.25" />
                            <Vertex pos="-2 -2 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.199998" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="0 -8 19.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -8 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="0 8 19.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 8 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-4 -4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 -2 -1.25" />
                            <Vertex pos="2 -2 -1.75" />
                            <Vertex pos="-2 2 1.75" />
                            <Vertex pos="-2 2 1.25" />
                            <Vertex pos="-2 -2 -1.25" />
                            <Vertex pos="-2 -2 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="4 -4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.75" />
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 -2 -1.25" />
                            <Vertex pos="2 -2 -1.75" />
                            <Vertex pos="-2 2 1.75" />
                            <Vertex pos="-2 2 1.25" />
                            <Vertex pos="-2 -2 -1.25" />
                            <Vertex pos="-2 -2 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-4 4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 2 -1.75" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 2 -1.75" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="4 4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 2 -1.75" />
                            <Vertex pos="2 -2 1.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 2 -1.75" />
                            <Vertex pos="-2 -2 1.75" />
                            <Vertex pos="-2 -2 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 -0.75 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.6 0.8 -0.2" album="" material="bm_friction_grass" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.6 -0.8 -0.2" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="0 0 22.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 22.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-9.75 -4 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -4 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-9.75 -4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-9.75 4 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 4 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-9.75 4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-22.25 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-22.25 0 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 0 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-22.25 0 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 0 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 2" />
                            <Vertex pos="0.25 6 -2" />
                            <Vertex pos="0.25 -6 2" />
                            <Vertex pos="0.25 -6 -2" />
                            <Vertex pos="-0.25 6 2" />
                            <Vertex pos="-0.25 6 -2" />
                            <Vertex pos="-0.25 -6 2" />
                            <Vertex pos="-0.25 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-16 6.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-16 6.25 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6.25 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-16 -6.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-16 -6.25 20.75" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6.25 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-9.75 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-22.25 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-9.75 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-22.25 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.25 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="8 0 21.5" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -0.499998" />
                            <Vertex pos="2 2 -1" />
                            <Vertex pos="2 -2 -0.499998" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 -2 1" />
                            <Vertex pos="-2 -2 0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.351123 0 0.936329 -0.234084" album="" material="bm_tile08_A" texgens="1 0 0 -1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.351123 0 -0.936329 -0.234082" album="" material="bm_grid_blank2" texgens="-1 0 0 1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-8 0 21.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 21.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 -0.5" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.234082" album="" material="bm_tile08_A" texgens="1 0 0 -1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.234082" album="" material="bm_grid_blank2" texgens="-1 0 0 1024 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="9.75 -4 16.25" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -4 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="9.75 -4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="9.75 4 16.25" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 4 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="9.75 4 20.75" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 4 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="9.75 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="9.75 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="16 6.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="16 6.25 20.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6.25 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="16 -6.25 16.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -6.25 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="16 -6.25 20.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -6.25 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.25 0.25" />
                            <Vertex pos="6.5 0.25 -0.25" />
                            <Vertex pos="6.5 -0.25 0.25" />
                            <Vertex pos="6.5 -0.25 -0.25" />
                            <Vertex pos="-6.5 0.25 0.25" />
                            <Vertex pos="-6.5 0.25 -0.25" />
                            <Vertex pos="-6.5 -0.25 0.25" />
                            <Vertex pos="-6.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.5" album="" material="bm_edge_white" texgens="0 -1 0 960 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 1664 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 -1536 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="22.25 0 16.25" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 0 0 0 1 16.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="22.25 0 20.75" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 0 0 0 1 20.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="22.25 0 18.5" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 0 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 6 2" />
                            <Vertex pos="0.25 6 -2" />
                            <Vertex pos="0.25 -6 2" />
                            <Vertex pos="0.25 -6 -2" />
                            <Vertex pos="-0.25 6 2" />
                            <Vertex pos="-0.25 6 -2" />
                            <Vertex pos="-0.25 -6 2" />
                            <Vertex pos="-0.25 -6 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="22.25 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="22.25 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 22.25 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2" />
                            <Vertex pos="0.25 0.25 -2" />
                            <Vertex pos="0.25 -0.25 2" />
                            <Vertex pos="0.25 -0.25 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 -0.25 2" />
                            <Vertex pos="-0.25 -0.25 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="4 -8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -15.5" />
                            <Vertex pos="2 -2 15.5" />
                            <Vertex pos="2 -2 -15.5" />
                            <Vertex pos="-2 2 15.5" />
                            <Vertex pos="-2 2 -15.5" />
                            <Vertex pos="-2 -2 15.5" />
                            <Vertex pos="-2 -2 -15.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.5" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-4 -8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -15.5" />
                            <Vertex pos="2 -2 15.5" />
                            <Vertex pos="2 -2 -15.5" />
                            <Vertex pos="-2 2 15.5" />
                            <Vertex pos="-2 2 -15.5" />
                            <Vertex pos="-2 -2 15.5" />
                            <Vertex pos="-2 -2 -15.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.5" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="4 8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -15.5" />
                            <Vertex pos="2 -2 15.5" />
                            <Vertex pos="2 -2 -15.5" />
                            <Vertex pos="-2 2 15.5" />
                            <Vertex pos="-2 2 -15.5" />
                            <Vertex pos="-2 -2 15.5" />
                            <Vertex pos="-2 -2 -15.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.5" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-4 8 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 8 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 15.5" />
                            <Vertex pos="2 2 -15.5" />
                            <Vertex pos="2 -2 15.5" />
                            <Vertex pos="2 -2 -15.5" />
                            <Vertex pos="-2 2 15.5" />
                            <Vertex pos="-2 2 -15.5" />
                            <Vertex pos="-2 -2 15.5" />
                            <Vertex pos="-2 -2 -15.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1536 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -2048 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15.5" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.5" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-24 4 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 4 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -0.75" />
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 -2 -0.75" />
                            <Vertex pos="2 -2 -1.25" />
                            <Vertex pos="-2 2 1.25" />
                            <Vertex pos="-2 2 0.749998" />
                            <Vertex pos="-2 -2 1.25" />
                            <Vertex pos="-2 -2 0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_friction_mud" texgens="1 0 0 -6144 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223608" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-24 -4 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -4 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -0.75" />
                            <Vertex pos="2 2 -1.25" />
                            <Vertex pos="2 -2 -0.75" />
                            <Vertex pos="2 -2 -1.25" />
                            <Vertex pos="-2 2 1.25" />
                            <Vertex pos="-2 2 0.749998" />
                            <Vertex pos="-2 -2 1.25" />
                            <Vertex pos="-2 -2 0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 640 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 -0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -0.223607" album="" material="bm_friction_mud" texgens="1 0 0 -6144 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.223608" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-28 0 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 0 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 -7168 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="-21 0 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 0 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="21 0 17.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 0 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 1" />
                            <Vertex pos="1 2 -1" />
                            <Vertex pos="1 -2 1" />
                            <Vertex pos="1 -2 -1" />
                            <Vertex pos="-1 2 1" />
                            <Vertex pos="-1 2 -1" />
                            <Vertex pos="-1 -2 1" />
                            <Vertex pos="-1 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile08_A" texgens="1 0 0 -768 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="0 0 27.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="-8 0 27.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_trim" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="8 0 27.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="0 4 27.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 4 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.25" />
                            <Vertex pos="2 2 -0.25" />
                            <Vertex pos="6 -2 0.25" />
                            <Vertex pos="6 -2 -0.25" />
                            <Vertex pos="-2 2 0.25" />
                            <Vertex pos="-2 2 -0.25" />
                            <Vertex pos="-6 -2 0.25" />
                            <Vertex pos="-6 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="0 -4 27.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -4 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 0.25" />
                            <Vertex pos="6 2 -0.25" />
                            <Vertex pos="2 -2 0.25" />
                            <Vertex pos="2 -2 -0.25" />
                            <Vertex pos="-6 2 0.25" />
                            <Vertex pos="-6 2 -0.25" />
                            <Vertex pos="-2 -2 0.25" />
                            <Vertex pos="-2 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile08_A" texgens="1 0 0 -512 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="-8 0 15" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.999998" />
                            <Vertex pos="2 2 9.53674e-007" />
                            <Vertex pos="2 -2 0.999998" />
                            <Vertex pos="2 -2 9.53674e-007" />
                            <Vertex pos="-2 2 0.999998" />
                            <Vertex pos="-2 2 -0.999999" />
                            <Vertex pos="-2 -2 0.999998" />
                            <Vertex pos="-2 -2 -0.999999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank2" texgens="0 1 0 1024 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank2" texgens="0 -1 0 -1536 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.999998" album="" material="bm_tile08_A" texgens="1 0 0 512 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.48507" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="1" type="999" pos="-8 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_A" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="5" type="999" pos="8 0 10.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 0 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile01_A" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="13" type="999" pos="21 1 17.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 1 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 3 1" />
                            <Vertex pos="1 3 -1" />
                            <Vertex pos="1 -3 1" />
                            <Vertex pos="1 -3 -1" />
                            <Vertex pos="-0.999998 3 -1" />
                            <Vertex pos="-0.999998 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank2" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 -0 -3" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0" />
                        </Face>
                        <Face id="2" plane="0 -1 -0 -3" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 3" />
                        </Face>
                        <Face id="3" plane="-0.707107 0 0.707106 7.15256e-007" album="" material="bm_tile01_A" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="9" type="999" pos="-21 -1 17.5" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 -1 0 0 1 17.5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 3 0.999998" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 -3 0.999998" />
                            <Vertex pos="-1 -3 -1" />
                            <Vertex pos="0.999998 3 -1" />
                            <Vertex pos="0.999998 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="" material="bm_grid_blank2" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 0 -3" album="" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -3" album="" material="bm_grid_blank2" texgens="1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.707107 -0 0.707107 1.37091e-006" album="" material="bm_tile01_A" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -1" album="" material="bm_grid_blank2" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="24 -4 21.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -4 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="2 -2 0.75" />
                            <Vertex pos="-2 2 -0.750002" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 -2 -0.750002" />
                            <Vertex pos="-2 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223605" album="" material="bm_friction_mud" texgens="1 0 0 6144 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="24 4 21.75" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 4 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="2 -2 0.75" />
                            <Vertex pos="-2 2 -0.750002" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 -2 -0.750002" />
                            <Vertex pos="-2 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 -384 0.5 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223605" album="" material="bm_friction_mud" texgens="1 0 0 6144 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="28 0 22.75" rot="1 0 0 0" scale="" transform="1 0 0 28 0 1 0 0 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 0.25" />
                            <Vertex pos="2 6 -0.25" />
                            <Vertex pos="2 -6 0.25" />
                            <Vertex pos="2 -6 -0.25" />
                            <Vertex pos="-2 6 0.25" />
                            <Vertex pos="-2 6 -0.25" />
                            <Vertex pos="-2 -6 0.25" />
                            <Vertex pos="-2 -6 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 512 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_friction_mud" texgens="1 0 0 7168 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank2" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="16 6.55651e-006 21.125" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6.55651e-006 0 0 1 21.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.125" />
                            <Vertex pos="2.5 2.5 -0.125" />
                            <Vertex pos="2 -2 0.125" />
                            <Vertex pos="2.5 -2.5 -0.124998" />
                            <Vertex pos="-2 2 0.125" />
                            <Vertex pos="-2.5 2.5 -0.125" />
                            <Vertex pos="-2 -2 0.125" />
                            <Vertex pos="-2.5 -2.5 -0.124998" />
                        </Vertices>
                        <Face id="0" plane="0.447212 -2.13247e-007 0.894428 -1.00623" album="" material="bm_edge_white" texgens="0 1 0 -383.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447215 2.55897e-007 0.894427 -1.00624" album="" material="bm_edge_white" texgens="0 -1 0 511.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.447215 0.894427 -1.00623" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.447212 0.894428 -1.00623" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_friction_bounce_high" texgens="1 0 0 512 0 -1 0 511.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -3.81469e-007 -1 -0.124999" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 255.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="-16 6.55651e-006 21.125" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6.55651e-006 0 0 1 21.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.00001 2 0.125" />
                            <Vertex pos="2.5 2.5 -0.125" />
                            <Vertex pos="2 -2 0.125" />
                            <Vertex pos="2.5 -2.5 -0.124998" />
                            <Vertex pos="-2.00001 2 0.125" />
                            <Vertex pos="-2.5 2.5 -0.125" />
                            <Vertex pos="-2 -2 0.125" />
                            <Vertex pos="-2.5 -2.5 -0.124998" />
                        </Vertices>
                        <Face id="0" plane="0.447211 -2.13247e-007 0.894428 -1.00623" album="" material="bm_edge_white" texgens="0 1 0 -383.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447215 1.70598e-007 0.894427 -1.00624" album="" material="bm_edge_white" texgens="0 -1 0 511.998 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.447215 0.894427 -1.00623" album="" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.447212 0.894428 -1.00623" album="" material="bm_edge_white" texgens="1 0 0 512 0 0 -1 64 0 0.125 0.0625" texRot="0" texScale="0.125 0.0625" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_friction_bounce_high" texgens="1 0 0 512 0 -1 0 511.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -3.81469e-007 -1 -0.124999" album="" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 255.999 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="16 6.25 16.625" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6.25 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="16 6.25 20.375" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 6.25 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="21.875 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 21.875 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="10.125 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 10.125 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="9.75 5.875 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 5.875 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="9.75 4 16.625" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 4 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="9.75 2.125 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 2.125 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="9.75 4 20.375" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 4 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="9.75 -2.125 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -2.125 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="9.75 -4 16.625" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -4 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="9.75 -5.875 18.5" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -5.875 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="9.75 -4 20.375" rot="1 0 0 0" scale="" transform="1 0 0 9.75 0 1 0 -4 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="16 -6.25 16.625" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -6.25 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="16 -6.25 20.375" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -6.25 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="21.875 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 21.875 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="10.125 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 10.125 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-16 6.25 16.625" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6.25 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-16 6.25 20.375" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 6.25 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-10.125 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.125 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-21.875 6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.875 0 1 0 6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-16 -6.25 16.625" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6.25 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-16 -6.25 20.375" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 -6.25 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 0.125 0.125" />
                            <Vertex pos="6 0.125 -0.125" />
                            <Vertex pos="6 -0.125 0.125" />
                            <Vertex pos="6 -0.125 -0.125" />
                            <Vertex pos="-6 0.125 0.125" />
                            <Vertex pos="-6 0.125 -0.125" />
                            <Vertex pos="-6 -0.125 0.125" />
                            <Vertex pos="-6 -0.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -4096 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-10.125 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -10.125 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 5600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -5600 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-21.875 -6.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -21.875 0 1 0 -6.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1600 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2592 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2592 0 -1 0 -1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-9.75 5.875 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 5.875 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-9.75 4 16.625" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 4 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-9.75 2.125 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 2.125 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-9.75 4 20.375" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 4 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-9.75 -2.125 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -2.125 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1504 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1504 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-9.75 -4 16.625" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -4 0 0 1 16.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-9.75 -5.875 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -5.875 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.125 1.75" />
                            <Vertex pos="0.125 0.125 -1.75" />
                            <Vertex pos="0.125 -0.125 1.75" />
                            <Vertex pos="0.125 -0.125 -1.75" />
                            <Vertex pos="-0.125 0.125 1.75" />
                            <Vertex pos="-0.125 0.125 -1.75" />
                            <Vertex pos="-0.125 -0.125 1.75" />
                            <Vertex pos="-0.125 -0.125 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -544 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -4736 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-9.75 -4 20.375" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -4 0 0 1 20.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 0.125" />
                            <Vertex pos="0.125 2 -0.125" />
                            <Vertex pos="0.125 -2 0.125" />
                            <Vertex pos="0.125 -2 -0.125" />
                            <Vertex pos="-0.125 2 0.125" />
                            <Vertex pos="-0.125 2 -0.125" />
                            <Vertex pos="-0.125 -2 0.125" />
                            <Vertex pos="-0.125 -2 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_wood" texgens="0 1 0 1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_wood" texgens="0 -1 0 -1024 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_wood" texgens="-1 0 0 -2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_wood" texgens="1 0 0 2496 0 0 -1 -5216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="" material="bm_wood" texgens="1 0 0 2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.125" album="" material="bm_wood" texgens="-1 0 0 -2496 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
