<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/03 15:37:06">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="38">
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
        <SceneShape id="12" type="1" entityID="18" dl="0" group="-1" locked="0" />
        <SceneShape id="13" type="1" entityID="19" dl="0" group="-1" locked="0" />
        <SceneShape id="14" type="1" entityID="20" dl="0" group="-1" locked="0" />
        <SceneShape id="15" type="1" entityID="21" dl="0" group="-1" locked="0" />
        <SceneShape id="16" type="1" entityID="22" dl="0" group="-1" locked="0" />
        <SceneShape id="17" type="1" entityID="24" dl="0" group="-1" locked="0" />
        <SceneShape id="18" type="1" entityID="25" dl="0" group="-1" locked="0" />
        <SceneShape id="19" type="1" entityID="26" dl="0" group="-1" locked="0" />
        <SceneShape id="20" type="1" entityID="28" dl="0" group="-1" locked="0" />
        <SceneShape id="21" type="1" entityID="29" dl="0" group="-1" locked="0" />
        <SceneShape id="22" type="1" entityID="30" dl="0" group="-1" locked="0" />
        <SceneShape id="23" type="1" entityID="32" dl="0" group="-1" locked="0" />
        <SceneShape id="24" type="1" entityID="33" dl="0" group="-1" locked="0" />
        <SceneShape id="25" type="1" entityID="34" dl="0" group="-1" locked="0" />
        <SceneShape id="26" type="1" entityID="35" dl="0" group="-1" locked="0" />
        <SceneShape id="27" type="1" entityID="36" dl="0" group="-1" locked="0" />
        <SceneShape id="28" type="1" entityID="38" dl="0" group="-1" locked="0" />
        <SceneShape id="29" type="1" entityID="39" dl="0" group="-1" locked="0" />
        <SceneShape id="30" type="1" entityID="40" dl="0" group="-1" locked="0" />
        <SceneShape id="31" type="1" entityID="41" dl="0" group="-1" locked="0" />
        <SceneShape id="32" type="1" entityID="42" dl="0" group="-1" locked="0" />
        <SceneShape id="33" type="1" entityID="44" dl="0" group="-1" locked="0" />
        <SceneShape id="34" type="1" entityID="45" dl="0" group="-1" locked="0" />
        <SceneShape id="35" type="1" entityID="46" dl="0" group="-1" locked="0" />
        <SceneShape id="36" type="1" entityID="47" dl="0" group="-1" locked="0" />
        <SceneShape id="37" type="1" entityID="48" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="49">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 3 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -1 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 3 8.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-45 -16 21" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-41 -16 21" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="-45 -16 21" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-38 -19 20" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-38 -23 20" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="-38 -19 20" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="13" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="14" classname="path_node" gametype="Torque" isPointEntity="1" origin="-32 -23 19.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="15" classname="path_node" gametype="Torque" isPointEntity="1" origin="-32 -19 19.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="16" classname="path_node" gametype="Torque" isPointEntity="1" origin="-32 -23 19.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="17" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="18" classname="path_node" gametype="Torque" isPointEntity="1" origin="5 66 5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="19" classname="path_node" gametype="Torque" isPointEntity="1" origin="5 64 5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="20" classname="path_node" gametype="Torque" isPointEntity="1" origin="5 64 5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="21" classname="path_node" gametype="Torque" isPointEntity="1" origin="5 66 5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="22" classname="path_node" gametype="Torque" isPointEntity="1" origin="5 66 5.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="23" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="24" classname="path_node" gametype="Torque" isPointEntity="1" origin="-50 29 18.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="25" classname="path_node" gametype="Torque" isPointEntity="1" origin="-46 29 18.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="26" classname="path_node" gametype="Torque" isPointEntity="1" origin="-50 29 18.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="27" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="28" classname="path_node" gametype="Torque" isPointEntity="1" origin="-41 24 22.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="29" classname="path_node" gametype="Torque" isPointEntity="1" origin="-41 20 22.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="30" classname="path_node" gametype="Torque" isPointEntity="1" origin="-41 24 22.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="31" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="32" classname="path_node" gametype="Torque" isPointEntity="1" origin="-36 9 28.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="33" classname="path_node" gametype="Torque" isPointEntity="1" origin="-32 9 28.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="34" classname="path_node" gametype="Torque" isPointEntity="1" origin="-32 9 28.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="35" classname="path_node" gametype="Torque" isPointEntity="1" origin="-36 9 28.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="36" classname="path_node" gametype="Torque" isPointEntity="1" origin="-36 9 28.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="37" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="38" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -14 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="39" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -10 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="40" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -10 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="41" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -14 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="42" classname="path_node" gametype="Torque" isPointEntity="1" origin="-9 -14 36.25" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="43" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="44" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -18 33.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="45" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -22 33.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="46" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -22 33.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="47" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -18 33.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="48" classname="path_node" gametype="Torque" isPointEntity="1" origin="1 -18 33.75" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="494">
                    <Brush id="0" owner="0" type="0" pos="0 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="1 6 0.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 6 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 512 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="1.25 10 0.25" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 10 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 1 0.25" />
                            <Vertex pos="2.25 1 -0.25" />
                            <Vertex pos="1.75 -1 0.25" />
                            <Vertex pos="1.75 -1 -0.25" />
                            <Vertex pos="-1.75 1 0.25" />
                            <Vertex pos="-1.75 1 -0.25" />
                            <Vertex pos="-2.25 -1 0.25" />
                            <Vertex pos="-2.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -1.94029" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -1.94029" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 576 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -32 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="3 14 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 14 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 3 0.25" />
                            <Vertex pos="3.5 3 -0.25" />
                            <Vertex pos="0.5 -3 0.25" />
                            <Vertex pos="0.5 -3 -0.25" />
                            <Vertex pos="-0.5 3 0.25" />
                            <Vertex pos="-0.5 3 -0.25" />
                            <Vertex pos="-3.5 -3 0.25" />
                            <Vertex pos="-3.5 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -1.78885" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -1.78885" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1024 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -192 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="4.75 18 0.25" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 18 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 1 0.25" />
                            <Vertex pos="2.25 1 -0.25" />
                            <Vertex pos="1.75 -1 0.25" />
                            <Vertex pos="1.75 -1 -0.25" />
                            <Vertex pos="-1.75 1 0.25" />
                            <Vertex pos="-1.75 1 -0.25" />
                            <Vertex pos="-2.25 -1 0.25" />
                            <Vertex pos="-2.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -1.94029" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -1.94029" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1472 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -32 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="5 25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1536 0 -1 0 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="5 32 0.375" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 32 0 0 1 0.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.375" />
                            <Vertex pos="2 1 -0.125" />
                            <Vertex pos="2 -1 0.125" />
                            <Vertex pos="2 -1 -0.375" />
                            <Vertex pos="-2 1 0.375" />
                            <Vertex pos="-2 1 -0.125" />
                            <Vertex pos="-2 -1 0.125" />
                            <Vertex pos="-2 -1 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1536 0 -1 0 -7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="5 34 0.749999" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 34 0 0 1 0.749999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.5" />
                            <Vertex pos="2 1 9.53674e-007" />
                            <Vertex pos="2 -1 -5.96046e-008" />
                            <Vertex pos="2 -1 -0.5" />
                            <Vertex pos="-2 1 0.5" />
                            <Vertex pos="-2 1 9.53674e-007" />
                            <Vertex pos="-2 -1 -5.96046e-008" />
                            <Vertex pos="-2 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1536 0 -1 0 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="5 36 1.375" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 36 0 0 1 1.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.625" />
                            <Vertex pos="2 1 0.125" />
                            <Vertex pos="2 -1 -0.125" />
                            <Vertex pos="2 -1 -0.625" />
                            <Vertex pos="-2 1 0.625" />
                            <Vertex pos="-2 1 0.125" />
                            <Vertex pos="-2 -1 -0.125" />
                            <Vertex pos="-2 -1 -0.625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1536 0 -1 0 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="5 38 2.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 38 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 1 0.749999" />
                            <Vertex pos="0 1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                            <Vertex pos="0 -1 -0.749999" />
                            <Vertex pos="-2 1 0.749999" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                            <Vertex pos="-2 -1 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="Blasted" material="bm_stripe_caution2" texgens="1 -1.5 0 224 0 -1 0 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="5 41 16" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 41 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="Blasted" material="bm_tile05_C" texgens="1 0 0 1536 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="5 22 6.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 22 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1536 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="6 16 6.75" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 16 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 1792 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="7 10 7.75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 10 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 -0.750001" />
                            <Vertex pos="2 3 -1.25" />
                            <Vertex pos="2 -3 1.25" />
                            <Vertex pos="2 -3 0.750001" />
                            <Vertex pos="-2 3 -0.750001" />
                            <Vertex pos="-2 3 -1.25" />
                            <Vertex pos="-2 -3 1.25" />
                            <Vertex pos="-2 -3 0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -0.23717" album="Blasted" material="bm_tile06_C" texgens="1 0 0 2048 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.316228 -0.948683 -0.23717" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="8 4 8.75" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 4 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 2304 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="2 3 8.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 3 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 768 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="1" type="999" pos="-9 3 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 3 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 2 0.25" />
                            <Vertex pos="8 2 -0.25" />
                            <Vertex pos="8 -2 0.25" />
                            <Vertex pos="8 -2 -0.25" />
                            <Vertex pos="-8 2 0.25" />
                            <Vertex pos="-8 2 -0.25" />
                            <Vertex pos="-8 -2 0.25" />
                            <Vertex pos="-8 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile03_C" texgens="1 0 0 -2048 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-24 -1 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -1 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -5888 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-18 3 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 3 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_trim" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -4352 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="0 -1 8.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -1 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-30 2 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 2 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 -9.53674e-007" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 0.499999" />
                            <Vertex pos="1 -1 -9.53674e-007" />
                            <Vertex pos="-1 1 -9.53674e-007" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.499999" />
                            <Vertex pos="-1 -1 -9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 -0.25 -1 63.9998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 -0.25 -1 63.9998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242535" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-30 9 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 9 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 -2.25" />
                            <Vertex pos="1 6 -2.75" />
                            <Vertex pos="1 -6 2.75" />
                            <Vertex pos="1 -6 2.25" />
                            <Vertex pos="-1 6 -2.25" />
                            <Vertex pos="-1 6 -2.75" />
                            <Vertex pos="-1 -6 2.75" />
                            <Vertex pos="-1 -6 2.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 -0.416667 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 -0.416667 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.384615 0.923077 -0.230769" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.384615 -0.923077 -0.230769" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-30 16 3" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 16 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 0" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 -1 2.38419e-007" />
                            <Vertex pos="-1 1 0" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 -1 2.38419e-007" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-30 20 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 20 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-29 24 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 24 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 1 -0.25" />
                            <Vertex pos="1.90735e-006 -1 0.25" />
                            <Vertex pos="1.90735e-006 -1 -0.25" />
                            <Vertex pos="-2 1 0.25" />
                            <Vertex pos="-2 1 -0.25" />
                            <Vertex pos="-2 -1 0.25" />
                            <Vertex pos="-2 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707106 0 -0.707108" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3712 0 -1 0 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-29 29 2.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 29 0 0 1 2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_trim" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3712 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-29 45 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 45 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3712 0 -1 0 -5760 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-29 53 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 53 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_sand" texgens="1 0 0 256 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-35 55 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 55 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -8704 0 -1 0 -13824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-42 54 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 54 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10496 0 -1 0 -13568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-43 43 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 43 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10752 0 -1 0 -10752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-48 36 4" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 36 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 14" />
                            <Vertex pos="3 3 -38" />
                            <Vertex pos="3 -3 14" />
                            <Vertex pos="3 -3 -38" />
                            <Vertex pos="-3 3 14" />
                            <Vertex pos="-3 3 -38" />
                            <Vertex pos="-3 -3 14" />
                            <Vertex pos="-3 -3 -38" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -12032 0 -1 0 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -38" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-44 36 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -44 0 1 0 36 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1" />
                            <Vertex pos="1 3 -0.500002" />
                            <Vertex pos="1 -3 1" />
                            <Vertex pos="1 -3 -0.500002" />
                            <Vertex pos="-1 3 1.5" />
                            <Vertex pos="-1 3 -1.5" />
                            <Vertex pos="-1 -3 1.5" />
                            <Vertex pos="-1 -3 -1.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -1.21268" album="Blasted" material="bm_friction_bounce_med" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447213 0 -0.894428 -0.894428" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-33 22 8" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 22 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 18" />
                            <Vertex pos="2 3 -42" />
                            <Vertex pos="2 -3 18" />
                            <Vertex pos="2 -3 -42" />
                            <Vertex pos="-2 3 18" />
                            <Vertex pos="-2 3 -42" />
                            <Vertex pos="-2 -3 18" />
                            <Vertex pos="-2 -3 -42" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -8192 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -42" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="-37 29 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 29 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_trim" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -9216 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="-36 36 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 36 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_trim" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -8960 0 -1 0 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="-36 22 8.5" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 22 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1.5" />
                            <Vertex pos="1 3 -1.5" />
                            <Vertex pos="1 -3 1.5" />
                            <Vertex pos="1 -3 -1.5" />
                            <Vertex pos="-1 3 0.999998" />
                            <Vertex pos="-1 3 -0.499997" />
                            <Vertex pos="-1 -3 0.999998" />
                            <Vertex pos="-1 -3 -0.499997" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242537 0 0.970142 -1.21268" album="Blasted" material="bm_friction_bounce_med" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447215 0 -0.894427 -0.894425" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="-48 22 5" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 22 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 15" />
                            <Vertex pos="3 3 -39" />
                            <Vertex pos="3 -3 15" />
                            <Vertex pos="3 -3 -39" />
                            <Vertex pos="-3 3 15" />
                            <Vertex pos="-3 3 -39" />
                            <Vertex pos="-3 -3 15" />
                            <Vertex pos="-3 -3 -39" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -12032 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -39" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="-43 15 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 15 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10752 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="-45 -5 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -5 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -11264 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-37 -5 11" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 4 21" />
                            <Vertex pos="6 4 -45" />
                            <Vertex pos="6 -4 21" />
                            <Vertex pos="6 -4 -45" />
                            <Vertex pos="-6 4 21" />
                            <Vertex pos="-6 4 -45" />
                            <Vertex pos="-6 -4 21" />
                            <Vertex pos="-6 -4 -45" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -9216 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -45" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-37 -15 12" rot="1 0 0 0" scale="" transform="1 0 0 -37 0 1 0 -15 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 22" />
                            <Vertex pos="6 6 -46" />
                            <Vertex pos="6 -6 22" />
                            <Vertex pos="6 -6 -46" />
                            <Vertex pos="-6 6 22" />
                            <Vertex pos="-6 6 -46" />
                            <Vertex pos="-6 -6 22" />
                            <Vertex pos="-6 -6 -46" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -22" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -9216 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -46" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="-22 -23 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -23 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -5376 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="-18 -22.5 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -22.5 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.5 0.25" />
                            <Vertex pos="1 2.5 -0.25" />
                            <Vertex pos="1 -1.5 0.25" />
                            <Vertex pos="1 -1.5 -0.25" />
                            <Vertex pos="-1 1.5 0.25" />
                            <Vertex pos="-1 1.5 -0.25" />
                            <Vertex pos="-1 -2.5 0.25" />
                            <Vertex pos="-1 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -1.78885" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -1.78885" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -4352 0.5 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="-10 -22 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 -22 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -2304 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="5 -1 8" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -1 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 18" />
                            <Vertex pos="2 2 -42" />
                            <Vertex pos="2 -2 18" />
                            <Vertex pos="2 -2 -42" />
                            <Vertex pos="-2 2 18" />
                            <Vertex pos="-2 2 -42" />
                            <Vertex pos="-2 -2 18" />
                            <Vertex pos="-2 -2 -42" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -18" album="Blasted" material="bm_tile05_C" texgens="1 0 0 1536 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -42" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="-5 -28 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -28 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2.25" />
                            <Vertex pos="2 4 1.75" />
                            <Vertex pos="2 -4 -1.75" />
                            <Vertex pos="2 -4 -2.25" />
                            <Vertex pos="-2 4 2.25" />
                            <Vertex pos="-2 4 1.75" />
                            <Vertex pos="-2 -4 -1.75" />
                            <Vertex pos="-2 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="-5 -36 11.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -36 0 0 1 11.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2.25" />
                            <Vertex pos="2 4 1.75" />
                            <Vertex pos="2 -4 -1.75" />
                            <Vertex pos="2 -4 -2.25" />
                            <Vertex pos="-2 4 2.25" />
                            <Vertex pos="-2 4 1.75" />
                            <Vertex pos="-2 -4 -1.75" />
                            <Vertex pos="-2 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="-9 -40 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -40 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2.25" />
                            <Vertex pos="2 4 1.75" />
                            <Vertex pos="2 -4 -1.75" />
                            <Vertex pos="2 -4 -2.25" />
                            <Vertex pos="-2 4 2.25" />
                            <Vertex pos="-2 4 1.75" />
                            <Vertex pos="-2 -4 -1.75" />
                            <Vertex pos="-2 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -2048 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="-9 -48 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -48 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 2.25" />
                            <Vertex pos="2 4 1.75" />
                            <Vertex pos="2 -4 -1.75" />
                            <Vertex pos="2 -4 -2.25" />
                            <Vertex pos="-2 4 2.25" />
                            <Vertex pos="-2 4 1.75" />
                            <Vertex pos="-2 -4 -1.75" />
                            <Vertex pos="-2 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -2048 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="-5 -46 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -46 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1024 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="-5 -42 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -42 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_friction_bounce_high" texgens="-1 0 0 0 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -2.68328" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="-9 -34 15.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -34 0 0 1 15.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 4" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 4" />
                            <Vertex pos="2 -2 -4" />
                            <Vertex pos="-2 2 4" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 4" />
                            <Vertex pos="-2 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -2.68328" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="-5 -36 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -36 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -640 0 -1 0 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="-4 -28 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -28 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -512 0 -1 0 3584 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="-6 -24 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -24 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 0.5" />
                            <Vertex pos="1 8 -2.38419e-007" />
                            <Vertex pos="1 -8 0.5" />
                            <Vertex pos="1 -8 -2.38419e-007" />
                            <Vertex pos="-1 8 2.38419e-007" />
                            <Vertex pos="-1 8 -0.5" />
                            <Vertex pos="-1 -8 2.38419e-007" />
                            <Vertex pos="-1 -8 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0.25 0 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0.25 0 -1 64.0001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -768 0 -1 0 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="-8 -20 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 -20 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -1024 0 -1 0 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="-12 -8 3.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 -8 0 0 1 3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 8 0.25" />
                            <Vertex pos="1 8 -0.25" />
                            <Vertex pos="1 -8 0.25" />
                            <Vertex pos="1 -8 -0.25" />
                            <Vertex pos="-1 8 0.25" />
                            <Vertex pos="-1 8 -0.25" />
                            <Vertex pos="-1 -8 0.25" />
                            <Vertex pos="-1 -8 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -1536 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="-14 4 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 4 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 0" />
                            <Vertex pos="1 12 -0.5" />
                            <Vertex pos="1 -12 0" />
                            <Vertex pos="1 -12 -0.5" />
                            <Vertex pos="-1 12 0.5" />
                            <Vertex pos="-1 12 0" />
                            <Vertex pos="-1 -12 0.5" />
                            <Vertex pos="-1 -12 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -1792 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="-12 20 3.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 20 0 0 1 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 12 0.5" />
                            <Vertex pos="1 12 0" />
                            <Vertex pos="1 -12 0.5" />
                            <Vertex pos="1 -12 0" />
                            <Vertex pos="-1 12 -2.38419e-007" />
                            <Vertex pos="-1 12 -0.5" />
                            <Vertex pos="-1 -12 -2.38419e-007" />
                            <Vertex pos="-1 -12 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2944 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2944 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242536" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -1536 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="-13 40.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 40.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8.5 0.25" />
                            <Vertex pos="2 8.5 -0.25" />
                            <Vertex pos="2 -8.5 0.25" />
                            <Vertex pos="2 -8.5 -0.25" />
                            <Vertex pos="-2 8.5 0.25" />
                            <Vertex pos="-2 8.5 -0.25" />
                            <Vertex pos="-2 -8.5 0.25" />
                            <Vertex pos="-2 -8.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2048 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -1664 0 -1 0 -5184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="-13 55 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 55 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -3072 0 -1 0 -13824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="-12 64 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 64 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 0.25" />
                            <Vertex pos="1 3 -0.25" />
                            <Vertex pos="1 -3 0.25" />
                            <Vertex pos="1 -3 -0.25" />
                            <Vertex pos="-3 3 0.25" />
                            <Vertex pos="-3 3 -0.25" />
                            <Vertex pos="-3 -3 0.25" />
                            <Vertex pos="-3 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -2816 0 -1 0 -16128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="-12 69 -3" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 69 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 7" />
                            <Vertex pos="1 2 -31" />
                            <Vertex pos="1 -2 7" />
                            <Vertex pos="1 -2 -31" />
                            <Vertex pos="-3 2 7" />
                            <Vertex pos="-3 2 -31" />
                            <Vertex pos="-3 -2 7" />
                            <Vertex pos="-3 -2 -31" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -31" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="-12 69 7" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 69 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 3" />
                            <Vertex pos="1 2 -3" />
                            <Vertex pos="1 -2 3" />
                            <Vertex pos="1 -2 -3" />
                            <Vertex pos="-3 2 3" />
                            <Vertex pos="-3 2 -3" />
                            <Vertex pos="-3 -2 3" />
                            <Vertex pos="-3 -2 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_friction_sand" texgens="1 0 0 384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="-12 69 14" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 69 0 0 1 14 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 2" />
                            <Vertex pos="1 2 -4" />
                            <Vertex pos="1 -2 2" />
                            <Vertex pos="1 -2 -4" />
                            <Vertex pos="-3 2 2" />
                            <Vertex pos="-3 2 -4" />
                            <Vertex pos="-3 -2 2" />
                            <Vertex pos="-3 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_friction_sand" texgens="1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="-7 -54 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -54 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-6 65 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 65 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 0.25" />
                            <Vertex pos="3 2 -0.25" />
                            <Vertex pos="3 -2 0.25" />
                            <Vertex pos="3 -2 -0.25" />
                            <Vertex pos="-5 2 0.25" />
                            <Vertex pos="-5 2 -0.25" />
                            <Vertex pos="-5 -2 0.25" />
                            <Vertex pos="-5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1280 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="17" type="999" pos="5 66 5.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 66 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 1 2.25" />
                            <Vertex pos="8 1 1.75" />
                            <Vertex pos="8 -1 2.25" />
                            <Vertex pos="8 -1 1.75" />
                            <Vertex pos="-8 1 -1.75" />
                            <Vertex pos="-8 1 -2.25" />
                            <Vertex pos="-8 -1 -1.75" />
                            <Vertex pos="-8 -1 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1920 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1920 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_tile03_C" texgens="1 0 0 1536 0 -1 0 -16640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -768 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="19 65 7.75" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 65 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 5120 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="24 60 2" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 60 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 12" />
                            <Vertex pos="3 3 -36" />
                            <Vertex pos="3 -3 12" />
                            <Vertex pos="3 -3 -36" />
                            <Vertex pos="-3 3 12" />
                            <Vertex pos="-3 3 -36" />
                            <Vertex pos="-3 -3 12" />
                            <Vertex pos="-3 -3 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12" album="Blasted" material="bm_tile05_C" texgens="1 0 0 6400 0 -1 0 -15104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="26 65 2" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 65 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 6" />
                            <Vertex pos="3 2 -36" />
                            <Vertex pos="3 -2 6" />
                            <Vertex pos="3 -2 -36" />
                            <Vertex pos="-1 2 6" />
                            <Vertex pos="-1 2 -36" />
                            <Vertex pos="-1 -2 6" />
                            <Vertex pos="-1 -2 -36" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_tile05_C" texgens="1 0 0 6912 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -36" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="25 55 13.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 55 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 6656 0 -1 0 -13824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="23" type="999" pos="-50 29 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -50 0 1 0 29 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 -0.75" />
                            <Vertex pos="1 4 -1.25" />
                            <Vertex pos="1 -4 1.25" />
                            <Vertex pos="1 -4 0.749998" />
                            <Vertex pos="-1 4 -0.75" />
                            <Vertex pos="-1 4 -1.25" />
                            <Vertex pos="-1 -4 1.25" />
                            <Vertex pos="-1 -4 0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="Blasted" material="bm_tile03_C" texgens="1 0 0 -12544 0 -1 0 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242535 -0.970143 -0.242537" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="31 41 17.75" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 41 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_trim" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 8192 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-2 41 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 41 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 2 0.25" />
                            <Vertex pos="5 2 -0.25" />
                            <Vertex pos="5 -2 0.25" />
                            <Vertex pos="5 -2 -0.25" />
                            <Vertex pos="-5 2 0.25" />
                            <Vertex pos="-5 2 -0.25" />
                            <Vertex pos="-5 -2 0.25" />
                            <Vertex pos="-5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -256 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-9 47 7" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 47 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 17" />
                            <Vertex pos="2 8 -41" />
                            <Vertex pos="2 -8 17" />
                            <Vertex pos="2 -8 -41" />
                            <Vertex pos="-2 8 17" />
                            <Vertex pos="-2 8 -41" />
                            <Vertex pos="-2 -8 17" />
                            <Vertex pos="-2 -8 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 -11776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-9 37 11" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 37 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 21" />
                            <Vertex pos="2 2 -45" />
                            <Vertex pos="2 -2 21" />
                            <Vertex pos="2 -2 -45" />
                            <Vertex pos="-2 2 21" />
                            <Vertex pos="-2 2 -45" />
                            <Vertex pos="-2 -2 21" />
                            <Vertex pos="-2 -2 -45" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -45" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-9 57 7" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 57 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -41" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -41" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -41" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 -14336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-17 57 7" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 57 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -41" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -41" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -41" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 -14336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-13 43 22" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 43 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 12 10" />
                            <Vertex pos="2 12 -10" />
                            <Vertex pos="2 -8 10" />
                            <Vertex pos="2 -8 -10" />
                            <Vertex pos="-2 12 10" />
                            <Vertex pos="-2 12 -10" />
                            <Vertex pos="-2 -12 10" />
                            <Vertex pos="-2 -12 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -7.07107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -3072 0 -1 0 -10752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -10" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="-17 33 7" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 33 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 17" />
                            <Vertex pos="2 2 -41" />
                            <Vertex pos="2 -2 17" />
                            <Vertex pos="2 -2 -41" />
                            <Vertex pos="-2 2 17" />
                            <Vertex pos="-2 2 -41" />
                            <Vertex pos="-2 -2 17" />
                            <Vertex pos="-2 -2 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-13 57 18" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 57 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 6" />
                            <Vertex pos="2 2 -6" />
                            <Vertex pos="2 -2 6" />
                            <Vertex pos="2 -2 -6" />
                            <Vertex pos="-2 2 6" />
                            <Vertex pos="-2 2 -6" />
                            <Vertex pos="-2 -2 6" />
                            <Vertex pos="-2 -2 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -3072 0 -1 0 -14336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-17 47 7" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 47 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 17" />
                            <Vertex pos="2 8 -41" />
                            <Vertex pos="2 -8 17" />
                            <Vertex pos="2 -8 -41" />
                            <Vertex pos="-2 8 17" />
                            <Vertex pos="-2 8 -41" />
                            <Vertex pos="-2 -8 17" />
                            <Vertex pos="-2 -8 -41" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 -11776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -41" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="-17 37 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 37 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1.25" />
                            <Vertex pos="2 2 0.75" />
                            <Vertex pos="2 -2 1.25" />
                            <Vertex pos="2 -2 0.75" />
                            <Vertex pos="-2 2 -0.75" />
                            <Vertex pos="-2 2 -1.25" />
                            <Vertex pos="-2 -2 -0.75" />
                            <Vertex pos="-2 -2 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -0.223607" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -2176 0 -1 0 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-17 61 13" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 61 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 31" />
                            <Vertex pos="2 2 -47" />
                            <Vertex pos="2 -2 35" />
                            <Vertex pos="2 -2 -47" />
                            <Vertex pos="-2 2 31" />
                            <Vertex pos="-2 2 -47" />
                            <Vertex pos="-2 -2 35" />
                            <Vertex pos="-2 -2 -47" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 3968 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -23.3345" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -47" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-13 61 24" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 61 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 20" />
                            <Vertex pos="2 2 -12" />
                            <Vertex pos="2 -2 24" />
                            <Vertex pos="2 -2 -12" />
                            <Vertex pos="-2 2 20" />
                            <Vertex pos="-2 2 -12" />
                            <Vertex pos="-2 -2 24" />
                            <Vertex pos="-2 -2 -12" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -15.5563" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-9 61 13" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 61 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 11" />
                            <Vertex pos="2 2 -47" />
                            <Vertex pos="2 -2 11" />
                            <Vertex pos="2 -2 -47" />
                            <Vertex pos="-2 2 11" />
                            <Vertex pos="-2 2 -47" />
                            <Vertex pos="-2 -2 11" />
                            <Vertex pos="-2 -2 -47" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 -15360 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -47" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="-21 37 20" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 37 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 0.499998" />
                            <Vertex pos="2 -2 1" />
                            <Vertex pos="2 -2 0.499998" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 2 -1" />
                            <Vertex pos="-2 -2 -0.5" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0.375 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.351123 0 0.936329 -0.234082" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -2688 0 -1 0 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.351123 0 -0.936329 -0.234083" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-25 37 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 37 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.749998" />
                            <Vertex pos="2 2 0.250002" />
                            <Vertex pos="2 -2 0.749998" />
                            <Vertex pos="2 -2 0.250002" />
                            <Vertex pos="-2 2 -0.250002" />
                            <Vertex pos="-2 2 -0.749998" />
                            <Vertex pos="-2 -2 -0.250002" />
                            <Vertex pos="-2 -2 -0.749998" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0.25 0 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0.25 0 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -0.242534" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -3200 0 -1 0 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242534" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-29 37 18" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 37 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="-2 2 0" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0.125 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0.125 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.124035 0 0.992278 -0.248069" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -3712 0 -1 0 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.124035 0 -0.992278 -0.248069" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-38 37 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 37 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -4864 0 -1 0 -4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -640 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-17 33 26" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 33 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_friction_sand" texgens="-1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-36 22 23" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 22 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 3" />
                            <Vertex pos="1 3 -3" />
                            <Vertex pos="1 -3 3" />
                            <Vertex pos="1 -3 -3" />
                            <Vertex pos="-1 3 3" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -8960 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="31" type="999" pos="-36 9 28.75" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 9 0 0 1 28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 10 -2.75" />
                            <Vertex pos="1 10 -3.25" />
                            <Vertex pos="1 -10 3.25" />
                            <Vertex pos="1 -10 2.75" />
                            <Vertex pos="-1 10 -2.75" />
                            <Vertex pos="-1 10 -3.25" />
                            <Vertex pos="-1 -10 3.25" />
                            <Vertex pos="-1 -10 2.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2432 0 -0.3 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2432 0 -0.3 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.287348 0.957826 -0.239456" album="Blasted" material="bm_tile03_C" texgens="1 0 0 -8960 0 -1 0 -2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.287348 -0.957826 -0.239456" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="6 4 25.75" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 4 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 1792 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="27" type="999" pos="-41 24 22.75" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 24 0 0 1 22.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 3.25" />
                            <Vertex pos="4 1 2.75" />
                            <Vertex pos="4 -1 3.25" />
                            <Vertex pos="4 -1 2.75" />
                            <Vertex pos="-4 1 -2.75" />
                            <Vertex pos="-4 1 -3.25" />
                            <Vertex pos="-4 -1 -2.75" />
                            <Vertex pos="-4 -1 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0.75 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0.75 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -0.2" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 128 -1 0 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.6 0 -0.8 -0.2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-40 -7 33" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -7 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 1" />
                            <Vertex pos="3 2 -1" />
                            <Vertex pos="3 -2 1" />
                            <Vertex pos="3 -2 -1" />
                            <Vertex pos="-3 2 1" />
                            <Vertex pos="-3 2 -1" />
                            <Vertex pos="-3 -2 1" />
                            <Vertex pos="-3 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -9984 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="-33 -18 35" rot="1 0 0 0" scale="" transform="1 0 0 -33 0 1 0 -18 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 1" />
                            <Vertex pos="2 3 -1" />
                            <Vertex pos="2 -3 1" />
                            <Vertex pos="2 -3 -1" />
                            <Vertex pos="-2 3 1" />
                            <Vertex pos="-2 3 -1" />
                            <Vertex pos="-2 -3 1" />
                            <Vertex pos="-2 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -8192 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-25 -15 13" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 -15 0 0 1 13 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 6 23" />
                            <Vertex pos="6 6 -47" />
                            <Vertex pos="6 -6 23" />
                            <Vertex pos="6 -6 -47" />
                            <Vertex pos="-6 6 23" />
                            <Vertex pos="-6 6 -47" />
                            <Vertex pos="-6 -6 23" />
                            <Vertex pos="-6 -6 -47" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -23" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -6144 0 -1 0 4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -47" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-45 -16 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -16 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5760 0 -1 0 2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-46 -24 19.25" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 -24 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -6144 0 0 -1 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_wood" texgens="0 -1 0 6144 0 0 -1 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_wood" texgens="-1 0 0 11776 0 0 -1 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_wood" texgens="1 0 0 -11776 0 0 -1 -4928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5888 0 -1 0 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="-45 -19 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -19 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -1.90735e-006" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -1.90735e-006" />
                            <Vertex pos="-2 -2 0" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5760 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124034 -0.992278 -0.24807" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="-41 -23 19" rot="1 0 0 0" scale="" transform="1 0 0 -41 0 1 0 -23 0 0 1 19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -0.500002" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="2 -2 -0.500002" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -1.90735e-006" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -1.90735e-006" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 -0.125 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -0.248069" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5248 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.248071" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="-35 -23 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -23 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 0" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 -0.125 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -0.248069" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -4480 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.248069" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-29 -23 18" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -23 0 0 1 18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 -1.90735e-006" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 -1.90735e-006" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.499998" />
                            <Vertex pos="-2 2 0" />
                            <Vertex pos="-2 -2 0.499998" />
                            <Vertex pos="-2 -2 0" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 -0.125 0 -1 63.9995 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.124035 0 0.992278 -0.248068" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -3712 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.124035 0 -0.992278 -0.248069" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-38 -23 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 -23 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -4864 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-32 -23 18.25" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 -23 0 0 1 18.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -4096 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-9 47 30" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 47 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 2" />
                            <Vertex pos="2 8 -2" />
                            <Vertex pos="2 -8 2" />
                            <Vertex pos="2 -8 -2" />
                            <Vertex pos="-2 8 2" />
                            <Vertex pos="-2 8 -2" />
                            <Vertex pos="-2 -8 2" />
                            <Vertex pos="-2 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2048 0 -1 0 -11776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-17 47 30" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 47 0 0 1 30 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 8 2" />
                            <Vertex pos="2 8 -2" />
                            <Vertex pos="2 -8 2" />
                            <Vertex pos="2 -8 -2" />
                            <Vertex pos="-2 8 2" />
                            <Vertex pos="-2 8 -2" />
                            <Vertex pos="-2 -8 2" />
                            <Vertex pos="-2 -8 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 -11776 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="-13 45 34" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 45 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -4 30" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="6 -10 30" />
                            <Vertex pos="6 -10 -2" />
                            <Vertex pos="-6 -4 30" />
                            <Vertex pos="-6 -4 -2" />
                            <Vertex pos="-6 -10 30" />
                            <Vertex pos="-6 -10 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1024 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -30" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="-13 57 32" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 57 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 20" />
                            <Vertex pos="6 2 -4" />
                            <Vertex pos="6 -2 24" />
                            <Vertex pos="6 -2 -4" />
                            <Vertex pos="-6 2 20" />
                            <Vertex pos="-6 2 -4" />
                            <Vertex pos="-6 -2 24" />
                            <Vertex pos="-6 -2 -4" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -15.5564" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="-15 33 34" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 33 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 6" />
                            <Vertex pos="4 2 -2" />
                            <Vertex pos="9.53674e-007 -2 2" />
                            <Vertex pos="9.53674e-007 -2 -2" />
                            <Vertex pos="-4 2 6" />
                            <Vertex pos="-4 2 -2" />
                            <Vertex pos="-4 -2 2" />
                            <Vertex pos="-4 -2 -2" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="-21 -12 37" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 -12 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 1" />
                            <Vertex pos="2 3 -1" />
                            <Vertex pos="2 -3 1" />
                            <Vertex pos="2 -3 -1" />
                            <Vertex pos="-2 3 1" />
                            <Vertex pos="-2 3 -1" />
                            <Vertex pos="-2 -3 1" />
                            <Vertex pos="-2 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -5120 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-17 -12 35" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -12 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 3" />
                            <Vertex pos="2 3 1" />
                            <Vertex pos="2 -3 3" />
                            <Vertex pos="2 -3 1" />
                            <Vertex pos="-2 3 3" />
                            <Vertex pos="-2 3 -3" />
                            <Vertex pos="-2 -3 3" />
                            <Vertex pos="-2 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -4096 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="37" type="999" pos="-9 -14 36.25" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -14 0 0 1 36.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 -1.25" />
                            <Vertex pos="6 1 -1.75" />
                            <Vertex pos="6 -1 -1.25" />
                            <Vertex pos="6 -1 -1.75" />
                            <Vertex pos="-6 1 1.75" />
                            <Vertex pos="-6 1 1.25" />
                            <Vertex pos="-6 -1 1.75" />
                            <Vertex pos="-6 -1 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1408 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1408 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="Blasted" material="bm_tile03_C" texgens="1 0 0 -2048 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="43" type="999" pos="1 -18 33.75" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -18 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 1 -1.25" />
                            <Vertex pos="6 1 -1.75" />
                            <Vertex pos="6 -1 -1.25" />
                            <Vertex pos="6 -1 -1.75" />
                            <Vertex pos="-6 1 1.75" />
                            <Vertex pos="-6 1 1.25" />
                            <Vertex pos="-6 -1 1.75" />
                            <Vertex pos="-6 -1 1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1408 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1408 -0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -0.242536" album="Blasted" material="bm_tile03_C" texgens="1 0 0 512 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970142 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="11 -21 11" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -21 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 21" />
                            <Vertex pos="2 2 -45" />
                            <Vertex pos="2 -2 21" />
                            <Vertex pos="2 -2 -45" />
                            <Vertex pos="-2 2 21" />
                            <Vertex pos="-2 2 -45" />
                            <Vertex pos="-2 -2 21" />
                            <Vertex pos="-2 -2 -45" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -21" album="Blasted" material="bm_tile05_C" texgens="1 0 0 3072 0 -1 0 5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -45" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-7 -58 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -58 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="28" nextVertexID="51">
                        <Vertices>
                            <Vertex pos="-3.96578 1.47781 -0.25" />
                            <Vertex pos="-3.96578 1.47781 0.25" />
                            <Vertex pos="-4 2 -0.25" />
                            <Vertex pos="-4 2 0.25" />
                            <Vertex pos="-3.86372 0.964691 -0.25" />
                            <Vertex pos="-3.86372 0.964691 0.25" />
                            <Vertex pos="-3.69549 0.469353 -0.249999" />
                            <Vertex pos="-3.69549 0.469353 0.25" />
                            <Vertex pos="-3.4641 1.52588e-005 -0.25" />
                            <Vertex pos="-3.4641 1.52588e-005 0.25" />
                            <Vertex pos="-3.17344 -0.434998 -0.25" />
                            <Vertex pos="-3.17344 -0.434998 0.25" />
                            <Vertex pos="-2.8285 -0.828369 -0.249999" />
                            <Vertex pos="-2.8285 -0.828369 0.25" />
                            <Vertex pos="-2.43497 -1.17353 -0.249999" />
                            <Vertex pos="-2.43497 -1.17353 0.25" />
                            <Vertex pos="-2.00003 -1.46405 -0.25" />
                            <Vertex pos="-2.00003 -1.46405 0.25" />
                            <Vertex pos="-1.53059 -1.69563 -0.25" />
                            <Vertex pos="-1.53059 -1.69563 0.25" />
                            <Vertex pos="-1.03529 -1.86374 -0.249999" />
                            <Vertex pos="-1.03529 -1.86374 0.25" />
                            <Vertex pos="-0.522275 -1.96592 -0.249999" />
                            <Vertex pos="-0.522275 -1.96592 0.25" />
                            <Vertex pos="9.25064e-005 -2 -0.25" />
                            <Vertex pos="9.25064e-005 -2 0.25" />
                            <Vertex pos="0.522179 -1.96595 -0.25" />
                            <Vertex pos="0.522179 -1.96595 0.25" />
                            <Vertex pos="1.0353 -1.86374 -0.249999" />
                            <Vertex pos="1.0353 -1.86374 0.25" />
                            <Vertex pos="1.53064 -1.69564 -0.25" />
                            <Vertex pos="1.53064 -1.69564 0.25" />
                            <Vertex pos="2.00001 -1.46405 -0.249999" />
                            <Vertex pos="2.00001 -1.46405 0.25" />
                            <Vertex pos="2.43504 -1.17343 -0.249999" />
                            <Vertex pos="2.43504 -1.17343 0.25" />
                            <Vertex pos="2.82844 -0.82843 -0.249999" />
                            <Vertex pos="2.82844 -0.82843 0.25" />
                            <Vertex pos="3.17341 -0.43499 -0.25" />
                            <Vertex pos="3.17341 -0.43499 0.25" />
                            <Vertex pos="3.46413 0 -0.249999" />
                            <Vertex pos="3.46413 0 0.25" />
                            <Vertex pos="3.69553 0.469376 -0.25" />
                            <Vertex pos="3.69553 0.469376 0.25" />
                            <Vertex pos="3.86372 0.964684 -0.25" />
                            <Vertex pos="3.86372 0.964684 0.25" />
                            <Vertex pos="3.96578 1.47781 -0.25" />
                            <Vertex pos="3.96578 1.47781 0.25" />
                            <Vertex pos="4 2 -0.25" />
                            <Vertex pos="4 2 0.25" />
                        </Vertices>
                        <Face id="0" plane="-0.99786 -0.0653914 -0 -3.86066" album="Blasted" material="bm_edge_white" texgens="0.0654019 -0.997859 0 552.136 0 0 -1 64 0 0.130827 0.125" texRot="0" texScale="0.130827 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.980787 -0.19508 0 -3.6013" album="Blasted" material="bm_edge_white" texgens="0.195078 -0.980788 0 543.826 0 0 -1 64 0 0.130815 0.125" texRot="0" texScale="0.130815 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.94688 -0.321586 0 -3.34825" album="Blasted" material="bm_edge_white" texgens="0.321446 -0.946928 0 527.558 0 0 -1 64 0 0.130732 0.125" texRot="0" texScale="0.130732 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="3" plane="-0.89692 -0.442194 0 -3.10701" album="Blasted" material="bm_edge_white" texgens="0.442299 -0.896868 0 502.642 0 0 -1 64 0 0.130871 0.125" texRot="0" texScale="0.130871 0.125" texDiv="128 128">
                            <Indices indices=" 9 8 6 7" />
                        </Face>
                        <Face id="4" plane="-0.831475 -0.555561 0 -2.88031" album="Blasted" material="bm_edge_white" texgens="0.555555 -0.83148 0 470.972 0 0 -1 64 0 0.130747 0.125" texRot="0" texScale="0.130747 0.125" texDiv="128 128">
                            <Indices indices=" 11 10 8 9" />
                        </Face>
                        <Face id="5" plane="-0.751875 -0.659306 0 -2.67283" album="Blasted" material="bm_edge_white" texgens="0.659351 -0.751835 0 432.036 0 0 -1 64 0 0.13074 0.125" texRot="0" texScale="0.13074 0.125" texDiv="128 128">
                            <Indices indices=" 13 12 10 11" />
                        </Face>
                        <Face id="6" plane="-0.659394 -0.751798 0 -2.48786" album="Blasted" material="bm_edge_white" texgens="0.751835 -0.659351 0 386.479 0 0 -1 64 0 0.130849 0.125" texRot="0" texScale="0.130849 0.125" texDiv="128 128">
                            <Indices indices=" 15 14 12 13" />
                        </Face>
                        <Face id="7" plane="-0.555441 -0.831556 0 -2.32834" album="Blasted" material="bm_edge_white" texgens="0.831471 -0.555569 0 335.94 0 0 -1 64 0 0.130743 0.125" texRot="0" texScale="0.130743 0.125" texDiv="128 128">
                            <Indices indices=" 17 16 14 15" />
                        </Face>
                        <Face id="8" plane="-0.442408 -0.896814 0 -2.19781" album="Blasted" material="bm_edge_white" texgens="0.896871 -0.442291 0 280.286 0 0 -1 64 0 0.130865 0.125" texRot="0" texScale="0.130865 0.125" texDiv="128 128">
                            <Indices indices=" 19 18 16 17" />
                        </Face>
                        <Face id="9" plane="-0.321402 -0.946943 0 -2.0976" album="Blasted" material="bm_edge_white" texgens="0.946934 -0.321429 0 221.317 0 0 -1 64 0 0.130751 0.125" texRot="0" texScale="0.130751 0.125" texDiv="128 128">
                            <Indices indices=" 21 20 18 19" />
                        </Face>
                        <Face id="10" plane="-0.195339 -0.980736 0 -2.03007" album="Blasted" material="bm_edge_white" texgens="0.980784 -0.195099 0 159.49 0 0 -1 64 0 0.130776 0.125" texRot="0" texScale="0.130776 0.125" texDiv="128 128">
                            <Indices indices=" 23 22 20 21" />
                        </Face>
                        <Face id="11" plane="-0.0651031 -0.997879 0 -1.99575" album="Blasted" material="bm_edge_white" texgens="0.997859 -0.0654019 0 95.9934 0 0 -1 64 0 0.130869 0.125" texRot="0" texScale="0.130869 0.125" texDiv="128 128">
                            <Indices indices=" 25 24 22 23" />
                        </Face>
                        <Face id="12" plane="0.0650808 -0.99788 0 -1.99577" album="Blasted" material="bm_edge_white" texgens="0.997859 0.065402 0 31.9831 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 27 26 24 25" />
                        </Face>
                        <Face id="13" plane="0.195355 -0.980733 0 -2.03008" album="Blasted" material="bm_edge_white" texgens="0.980784 0.195098 0 -31.4809 0 0 -1 64 0 0.130783 0.125" texRot="0" texScale="0.130783 0.125" texDiv="128 128">
                            <Indices indices=" 29 28 26 27" />
                        </Face>
                        <Face id="14" plane="0.321362 -0.946956 0 -2.09759" album="Blasted" material="bm_edge_white" texgens="0.946928 0.321446 0 -93.3321 0 0 -1 64 0 0.13075 0.125" texRot="0" texScale="0.13075 0.125" texDiv="128 128">
                            <Indices indices=" 31 30 28 29" />
                        </Face>
                        <Face id="15" plane="0.442477 -0.89678 0 -2.19789" album="Blasted" material="bm_edge_white" texgens="0.896879 0.442276 0 -152.294 0 0 -1 64 0 0.130863 0.125" texRot="0" texScale="0.130863 0.125" texDiv="128 128">
                            <Indices indices=" 33 32 30 31" />
                        </Face>
                        <Face id="16" plane="0.555494 -0.83152 0 -2.32838" album="Blasted" material="bm_edge_white" texgens="0.831465 0.555578 0 -207.892 0 0 -1 64 0 0.130777 0.125" texRot="0" texScale="0.130777 0.125" texDiv="128 128">
                            <Indices indices=" 35 34 32 33" />
                        </Face>
                        <Face id="17" plane="0.659343 -0.751842 0 -2.48776" album="Blasted" material="bm_edge_white" texgens="0.751835 0.659351 0 -258.643 0 0 -1 64 0 0.130791 0.125" texRot="0" texScale="0.130791 0.125" texDiv="128 128">
                            <Indices indices=" 37 36 34 35" />
                        </Face>
                        <Face id="18" plane="0.751904 -0.659273 0 -2.67288" album="Blasted" material="bm_edge_white" texgens="0.659351 0.751835 0 -303.92 0 0 -1 64 0 0.130791 0.125" texRot="0" texScale="0.130791 0.125" texDiv="128 128">
                            <Indices indices=" 39 38 36 37" />
                        </Face>
                        <Face id="19" plane="0.831409 -0.555661 0 -2.88011" album="Blasted" material="bm_edge_white" texgens="0.555569 0.831471 0 -342.845 0 0 -1 64 0 0.130799 0.125" texRot="0" texScale="0.130799 0.125" texDiv="128 128">
                            <Indices indices=" 41 40 38 39" />
                        </Face>
                        <Face id="20" plane="0.896926 -0.44218 0 -3.10707" album="Blasted" material="bm_edge_white" texgens="0.442276 0.896879 0 -374.862 0 0 -1 64 0 0.130798 0.125" texRot="0" texScale="0.130798 0.125" texDiv="128 128">
                            <Indices indices=" 43 42 40 41" />
                        </Face>
                        <Face id="21" plane="0.946898 -0.321535 0 -3.34837" album="Blasted" material="bm_edge_white" texgens="0.321446 0.946928 0 -399.391 0 0 -1 64 0 0.130785 0.125" texRot="0" texScale="0.130785 0.125" texDiv="128 128">
                            <Indices indices=" 45 44 42 43" />
                        </Face>
                        <Face id="22" plane="0.980788 -0.195077 0 -3.6013" album="Blasted" material="bm_edge_white" texgens="0.195079 0.980788 0 -415.71 0 0 -1 64 0 0.130838 0.125" texRot="0" texScale="0.130838 0.125" texDiv="128 128">
                            <Indices indices=" 47 46 44 45" />
                        </Face>
                        <Face id="23" plane="0.99786 -0.0653914 0 -3.86066" album="Blasted" material="bm_edge_white" texgens="0.0654041 0.997859 0 -423.991 0 0 -1 64 0 0.130862 0.125" texRot="0" texScale="0.130862 0.125" texDiv="128 128">
                            <Indices indices=" 49 48 46 47" />
                        </Face>
                        <Face id="24" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 48 2 0 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46" />
                        </Face>
                        <Face id="25" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -1536 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 49 47 45 43 41 39 37 35 33 31 29 27 25 23 21 19 17 15 13 11 9 7 5 1 3" />
                        </Face>
                        <Face id="26" plane="-0 1 0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 49 3 2 48" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-55 37 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -55 0 1 0 37 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -13824 0 -1 0 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-45 -10 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -10 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5760 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-45 -13 20" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -13 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 0" />
                            <Vertex pos="2 -2 -1.90735e-006" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 0" />
                            <Vertex pos="-2 -2 -1.90735e-006" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -5760 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-26 -23 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -26 0 1 0 -23 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_mud" texgens="1 0 0 -3328 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="12 -15 30.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -15 0 0 1 30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 -0.750002" />
                            <Vertex pos="1 4 -1.25" />
                            <Vertex pos="1 -4 1.25" />
                            <Vertex pos="1 -4 0.75" />
                            <Vertex pos="-1 4 -0.750002" />
                            <Vertex pos="-1 4 -1.25" />
                            <Vertex pos="-1 -4 1.25" />
                            <Vertex pos="-1 -4 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 -0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -0.242535" album="Blasted" material="bm_friction_ice" texgens="1 0 0 1536 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="2 -5 26.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 -5 0 0 1 26.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 -0.749998" />
                            <Vertex pos="1 4 -1.25" />
                            <Vertex pos="1 -4 1.25" />
                            <Vertex pos="1 -4 0.75" />
                            <Vertex pos="-1 4 -0.749998" />
                            <Vertex pos="-1 4 -1.25" />
                            <Vertex pos="-1 -4 1.25" />
                            <Vertex pos="-1 -4 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 -0.25 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 -0.25 -1 64.0005 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242535 0.970143 -0.242537" album="Blasted" material="bm_friction_ice" texgens="1 0 0 256 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="7 -10 28.75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 -10 0 0 1 28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 1 1.25" />
                            <Vertex pos="4 1 0.75" />
                            <Vertex pos="4 -1 1.25" />
                            <Vertex pos="4 -1 0.75" />
                            <Vertex pos="-4 1 -0.750002" />
                            <Vertex pos="-4 1 -1.25" />
                            <Vertex pos="-4 -1 -0.750002" />
                            <Vertex pos="-4 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0.25 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -0.242535" album="Blasted" material="bm_friction_sand" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.242536" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="2 0 23" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0 0 0 1 23 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 3" />
                            <Vertex pos="1 1 -3" />
                            <Vertex pos="1 -1 3" />
                            <Vertex pos="1 -1 -3" />
                            <Vertex pos="-1 1 3" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 3" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_tile05_C" texgens="1 0 0 768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="0 -3.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-2.5 3.25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 3.25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-3.25 0 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -3.25 0 1 0 0 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="3.25 5 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.25 0 1 0 5 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-1.25 6 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.25 0 1 0 6 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-1 10 0.25" rot="1 0 0 0" scale="" transform="1 0 0 -1 0 1 0 10 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="-1.19209e-007 -1 0.25" />
                            <Vertex pos="-1.19209e-007 -1 -0.25" />
                            <Vertex pos="0 1 0.25" />
                            <Vertex pos="0 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="3.5 10 0.25" rot="1 0 0 0" scale="" transform="1 0 0 3.5 0 1 0 10 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="2.38419e-007 -1 0.25" />
                            <Vertex pos="2.38419e-007 -1 -0.25" />
                            <Vertex pos="2.38419e-007 1 0.25" />
                            <Vertex pos="2.38419e-007 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.25 0 67.9393 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="2.5 18 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 18 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                            <Vertex pos="0 1 0.25" />
                            <Vertex pos="0 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="7 18 0.25" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 18 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 0.25" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0 -1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                            <Vertex pos="4.76837e-007 1 0.25" />
                            <Vertex pos="4.76837e-007 1 -0.25" />
                            <Vertex pos="-0.5 -1 0.25" />
                            <Vertex pos="-0.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 0.242536 0 -0.242535" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.25 0 67.9394 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="0.75 14 0.25" rot="1 0 0 0" scale="" transform="1 0 0 0.75 0 1 0 14 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 3 0.25" />
                            <Vertex pos="1.75 3 -0.25" />
                            <Vertex pos="-1.25 -3 0.25" />
                            <Vertex pos="-1.25 -3 -0.25" />
                            <Vertex pos="1.25 3 0.25" />
                            <Vertex pos="1.25 3 -0.25" />
                            <Vertex pos="-1.75 -3 0.25" />
                            <Vertex pos="-1.75 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.5 0 79.1084 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.5 0 79.1084 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="5.25 14 0.25" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 14 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 3 0.25" />
                            <Vertex pos="1.75 3 -0.25" />
                            <Vertex pos="-1.25 -3 0.25" />
                            <Vertex pos="-1.25 -3 -0.25" />
                            <Vertex pos="1.25 3 0.25" />
                            <Vertex pos="1.25 3 -0.25" />
                            <Vertex pos="-1.75 -3 0.25" />
                            <Vertex pos="-1.75 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 -0.5 0 79.1084 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0.5 0 79.1084 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="2.75 25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="7.25 25 0.25" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 25 0 0 1 0.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="2.75 32 0.375" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 32 0 0 1 0.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.375" />
                            <Vertex pos="0.25 1 -0.125" />
                            <Vertex pos="0.25 -1 0.125" />
                            <Vertex pos="0.25 -1 -0.375" />
                            <Vertex pos="-0.25 1 0.375" />
                            <Vertex pos="-0.25 1 -0.125" />
                            <Vertex pos="-0.25 -1 0.125" />
                            <Vertex pos="-0.25 -1 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="2.75 34 0.749999" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 34 0 0 1 0.749999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 9.53674e-007" />
                            <Vertex pos="0.25 -1 -5.96046e-008" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 9.53674e-007" />
                            <Vertex pos="-0.25 -1 -5.96046e-008" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="2.75 36 1.375" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 36 0 0 1 1.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.625" />
                            <Vertex pos="0.25 1 0.125" />
                            <Vertex pos="0.25 -1 -0.125" />
                            <Vertex pos="0.25 -1 -0.625" />
                            <Vertex pos="-0.25 1 0.625" />
                            <Vertex pos="-0.25 1 0.125" />
                            <Vertex pos="-0.25 -1 -0.125" />
                            <Vertex pos="-0.25 -1 -0.625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0.375 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="2.75 38 2.25" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 38 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.749999" />
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="0.25 -1 -0.749999" />
                            <Vertex pos="-0.25 1 0.749999" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                            <Vertex pos="-0.25 -1 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="7.25 32 0.375" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 32 0 0 1 0.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.375" />
                            <Vertex pos="0.25 1 -0.125" />
                            <Vertex pos="0.25 -1 0.125" />
                            <Vertex pos="0.25 -1 -0.375" />
                            <Vertex pos="-0.25 1 0.375" />
                            <Vertex pos="-0.25 1 -0.125" />
                            <Vertex pos="-0.25 -1 0.125" />
                            <Vertex pos="-0.25 -1 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0.125 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.124035 0.992278 -0.248069" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.124035 -0.992278 -0.248069" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="7.25 34 0.749999" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 34 0 0 1 0.749999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.5" />
                            <Vertex pos="0.25 1 9.53674e-007" />
                            <Vertex pos="0.25 -1 -5.96046e-008" />
                            <Vertex pos="0.25 -1 -0.5" />
                            <Vertex pos="-0.25 1 0.5" />
                            <Vertex pos="-0.25 1 9.53674e-007" />
                            <Vertex pos="-0.25 -1 -5.96046e-008" />
                            <Vertex pos="-0.25 -1 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0.25 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970142 -0.242535" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="7.25 36 1.375" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 36 0 0 1 1.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.625" />
                            <Vertex pos="0.25 1 0.125" />
                            <Vertex pos="0.25 -1 -0.125" />
                            <Vertex pos="0.25 -1 -0.625" />
                            <Vertex pos="-0.25 1 0.625" />
                            <Vertex pos="-0.25 1 0.125" />
                            <Vertex pos="-0.25 -1 -0.125" />
                            <Vertex pos="-0.25 -1 -0.625" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0.375 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 160 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234082" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234082" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="7.25 38 2.25" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 38 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.749999" />
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="0.25 -1 -0.749999" />
                            <Vertex pos="-0.25 1 0.749999" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                            <Vertex pos="-0.25 -1 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="5 41 5.5" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 41 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 2.5" />
                            <Vertex pos="2 2 -2.5" />
                            <Vertex pos="2 -2 2.5" />
                            <Vertex pos="2 -2 -2.5" />
                            <Vertex pos="-2 2 2.5" />
                            <Vertex pos="-2 2 -2.5" />
                            <Vertex pos="-2 -2 2.5" />
                            <Vertex pos="-2 -2 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_stripe_caution1" texgens="1 0 1 288 0 0 -1 160 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="5 41 -3.5" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 41 0 0 1 -3.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 6.5" />
                            <Vertex pos="2 2 -30.5" />
                            <Vertex pos="2 -2 6.5" />
                            <Vertex pos="2 -2 -30.5" />
                            <Vertex pos="-2 2 6.5" />
                            <Vertex pos="-2 2 -30.5" />
                            <Vertex pos="-2 -2 6.5" />
                            <Vertex pos="-2 -2 -30.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6.5" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -30.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="2.75 19 6.75" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 19 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="7.25 22 6.75" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 22 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="8.5 19.25 6.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 19.25 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="3.5 12.75 6.75" rot="1 0 0 0" scale="" transform="1 0 0 3.5 0 1 0 12.75 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="9.25 16 6.75" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 16 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="9.25 10 7.75" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 10 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -0.750001" />
                            <Vertex pos="0.25 3 -1.25" />
                            <Vertex pos="0.25 -3 1.25" />
                            <Vertex pos="0.25 -3 0.750001" />
                            <Vertex pos="-0.25 3 -0.750001" />
                            <Vertex pos="-0.25 3 -1.25" />
                            <Vertex pos="-0.25 -3 1.25" />
                            <Vertex pos="-0.25 -3 0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 -0.333333 -1 64.0003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -0.23717" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.316228 -0.948683 -0.23717" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="4.75 10 7.75" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 10 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -0.750001" />
                            <Vertex pos="0.25 3 -1.25" />
                            <Vertex pos="0.25 -3 1.25" />
                            <Vertex pos="0.25 -3 0.750001" />
                            <Vertex pos="-0.25 3 -0.750001" />
                            <Vertex pos="-0.25 3 -1.25" />
                            <Vertex pos="-0.25 -3 1.25" />
                            <Vertex pos="-0.25 -3 0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 -0.333333 -1 64.0003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -0.23717" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.316228 -0.948683 -0.23717" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="2.75 39.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 39.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2.75" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 2.75" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 2.25" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 2.25" />
                            <Vertex pos="-0.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 -1.76777" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="7.25 39.25 5.25" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 39.25 0 0 1 5.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 2.25" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 2.25" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 2.75" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 2.75" />
                            <Vertex pos="-0.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -1.76777" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="10.5 7.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 10.5 0 1 0 7.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="11.25 4 8.75" rot="1 0 0 0" scale="" transform="1 0 0 11.25 0 1 0 4 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="9.25 0.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 0.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="2 5.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 5.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="0 -3.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -3.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="5 25.125 6.75" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 25.125 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="4.75 6.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 4.75 0 1 0 6.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.75 0.25" />
                            <Vertex pos="0.25 0.75 -0.25" />
                            <Vertex pos="0.25 -0.75 0.25" />
                            <Vertex pos="0.25 -0.75 -0.25" />
                            <Vertex pos="-0.25 0.75 0.25" />
                            <Vertex pos="-0.25 0.75 -0.25" />
                            <Vertex pos="-0.25 -0.75 0.25" />
                            <Vertex pos="-0.25 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="1.25 -1.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 1.25 0 1 0 -1.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="2 0.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 0.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-18 5.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 5.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-24 -3.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -3.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-19.25 3.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 3.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-24 1.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 1.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.25 0.25" />
                            <Vertex pos="5 0.25 -0.25" />
                            <Vertex pos="5 -0.25 0.25" />
                            <Vertex pos="5 -0.25 -0.25" />
                            <Vertex pos="-5 0.25 0.25" />
                            <Vertex pos="-5 0.25 -0.25" />
                            <Vertex pos="-5 -0.25 0.25" />
                            <Vertex pos="-5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1152 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-31.25 0 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.25 0 1 0 0 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-29 53 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 53 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -7168 0 -1 0 -13312 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-31.25 53 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.25 0 1 0 53 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-26.75 53 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -26.75 0 1 0 53 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-26.75 53 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -26.75 0 1 0 53 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-45.25 54 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 54 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-40.75 43 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 43 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-36 57.25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -36 0 1 0 57.25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.5 0.25 0.25" />
                            <Vertex pos="9.5 0.25 -0.25" />
                            <Vertex pos="9.5 -0.25 0.25" />
                            <Vertex pos="9.5 -0.25 -0.25" />
                            <Vertex pos="-9.5 0.25 0.25" />
                            <Vertex pos="-9.5 0.25 -0.25" />
                            <Vertex pos="-9.5 -0.25 0.25" />
                            <Vertex pos="-9.5 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -9.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -2304 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -2304 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-35 52.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 52.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-38.75 52 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -38.75 0 1 0 52 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-39.5 50.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -39.5 0 1 0 50.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-35.75 39.25 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -35.75 0 1 0 39.25 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-33.5 32.75 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 32.75 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-32.75 36 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -32.75 0 1 0 36 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-39.25 29 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -39.25 0 1 0 29 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-34.75 29 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -34.75 0 1 0 29 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-43 22 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 22 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_trim" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10752 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-45.25 15 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 15 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-40.75 15 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 15 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-43.25 25.25 13.25" rot="1 0 0 0" scale="" transform="1 0 0 -43.25 0 1 0 25.25 0 0 1 13.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-42.75 2 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -42.75 0 1 0 2 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -1.5" />
                            <Vertex pos="0.25 3 -2" />
                            <Vertex pos="0.25 -3 2" />
                            <Vertex pos="0.25 -3 1.5" />
                            <Vertex pos="-0.25 3 -1.5" />
                            <Vertex pos="-0.25 3 -2" />
                            <Vertex pos="-0.25 -3 2" />
                            <Vertex pos="-0.25 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 -0.583333 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-47.25 2 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -47.25 0 1 0 2 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -1.5" />
                            <Vertex pos="0.25 3 -2" />
                            <Vertex pos="0.25 -3 2" />
                            <Vertex pos="0.25 -3 1.5" />
                            <Vertex pos="-0.25 3 -1.5" />
                            <Vertex pos="-0.25 3 -2" />
                            <Vertex pos="-0.25 -3 2" />
                            <Vertex pos="-0.25 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 -0.583333 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-44 5 16.75" rot="1 0 0 0" scale="" transform="1 0 0 -44 0 1 0 5 0 0 1 16.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 6 -3.25" />
                            <Vertex pos="1 6 -3.75" />
                            <Vertex pos="1 -6 3.75" />
                            <Vertex pos="1 -6 3.25" />
                            <Vertex pos="-1 6 -3.25" />
                            <Vertex pos="-1 6 -3.75" />
                            <Vertex pos="-1 -6 3.75" />
                            <Vertex pos="-1 -6 3.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -5632 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-46 2 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -46 0 1 0 2 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -1.5" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 1.5" />
                            <Vertex pos="-1 3 -1.5" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -11520 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-47.25 -5 20.25" rot="1 0 0 0" scale="" transform="1 0 0 -47.25 0 1 0 -5 0 0 1 20.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="-22 -25.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -22 0 1 0 -25.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-18 -24.75 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -24.75 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.75 0.25" />
                            <Vertex pos="1 0.75 -0.25" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                            <Vertex pos="-1 -0.75 0.25" />
                            <Vertex pos="-1 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-18 -20.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -20.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.75 0.25" />
                            <Vertex pos="1 0.75 -0.25" />
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                            <Vertex pos="-1 -0.75 0.25" />
                            <Vertex pos="-1 -0.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0.5 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-12.25 -24.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 -24.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.75 0.25 0.25" />
                            <Vertex pos="4.75 0.25 -0.25" />
                            <Vertex pos="4.75 -0.25 0.25" />
                            <Vertex pos="4.75 -0.25 -0.25" />
                            <Vertex pos="-4.75 0.25 0.25" />
                            <Vertex pos="-4.75 0.25 -0.25" />
                            <Vertex pos="-4.75 -0.25 0.25" />
                            <Vertex pos="-4.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1088 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1088 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="-9.75 -19.75 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -9.75 0 1 0 -19.75 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.25 0.25 0.25" />
                            <Vertex pos="7.25 0.25 -0.25" />
                            <Vertex pos="7.25 -0.25 0.25" />
                            <Vertex pos="7.25 -0.25 -0.25" />
                            <Vertex pos="-7.25 0.25 0.25" />
                            <Vertex pos="-7.25 0.25 -0.25" />
                            <Vertex pos="-7.25 -0.25 0.25" />
                            <Vertex pos="-7.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1728 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1728 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-2.75 -22 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -22 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="-2.75 -32 13.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -32 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 4.25" />
                            <Vertex pos="0.25 8 3.75" />
                            <Vertex pos="0.25 -8 -3.75" />
                            <Vertex pos="0.25 -8 -4.25" />
                            <Vertex pos="-0.25 8 4.25" />
                            <Vertex pos="-0.25 8 3.75" />
                            <Vertex pos="-0.25 -8 -3.75" />
                            <Vertex pos="-0.25 -8 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1920 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1920 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="-11.25 -44 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -11.25 0 1 0 -44 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 8 4.25" />
                            <Vertex pos="0.25 8 3.75" />
                            <Vertex pos="0.25 -8 -3.75" />
                            <Vertex pos="0.25 -8 -4.25" />
                            <Vertex pos="-0.25 8 4.25" />
                            <Vertex pos="-0.25 8 3.75" />
                            <Vertex pos="-0.25 -8 -3.75" />
                            <Vertex pos="-0.25 -8 -4.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1920 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1920 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 1088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-7.25 -28 15.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.25 0 1 0 -28 0 0 1 15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 2.25" />
                            <Vertex pos="0.25 4 1.75" />
                            <Vertex pos="0.25 -4 -1.75" />
                            <Vertex pos="0.25 -4 -2.25" />
                            <Vertex pos="-0.25 4 2.25" />
                            <Vertex pos="-0.25 4 1.75" />
                            <Vertex pos="-0.25 -4 -1.75" />
                            <Vertex pos="-0.25 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-6.75 -48 5.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 -48 0 0 1 5.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 2.25" />
                            <Vertex pos="0.25 4 1.75" />
                            <Vertex pos="0.25 -4 -1.75" />
                            <Vertex pos="0.25 -4 -2.25" />
                            <Vertex pos="-0.25 4 2.25" />
                            <Vertex pos="-0.25 4 1.75" />
                            <Vertex pos="-0.25 -4 -1.75" />
                            <Vertex pos="-0.25 -4 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0.5 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="-11.25 -54 4" rot="1 0 0 0" scale="" transform="1 0 0 -11.25 0 1 0 -54 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 2 0" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="-7.25 -46 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.25 0 1 0 -46 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="-2.75 -52 4" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -52 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 4 0.5" />
                            <Vertex pos="0.25 4 -0.5" />
                            <Vertex pos="0.25 -4 0.5" />
                            <Vertex pos="0.25 -4 -0.5" />
                            <Vertex pos="-0.25 4 0.5" />
                            <Vertex pos="-0.25 4 -0.5" />
                            <Vertex pos="-0.25 -4 0.5" />
                            <Vertex pos="-0.25 -4 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="-15.25 37 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 37 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="-15.25 37 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 37 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="-15.25 65 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 65 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-15.25 69 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 69 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 -1.75" />
                            <Vertex pos="0.25 2 -2.25" />
                            <Vertex pos="0.25 -2 -1.75" />
                            <Vertex pos="0.25 -2 -2.25" />
                            <Vertex pos="-0.25 2 -1.75" />
                            <Vertex pos="-0.25 2 -2.25" />
                            <Vertex pos="-0.25 -2 -1.75" />
                            <Vertex pos="-0.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-15.25 67.25 10.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 67.25 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 5" />
                            <Vertex pos="0.25 0.25 -7" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 -0.25 -7" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="-0.25 0.25 -7" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="-8.75 67.25 10.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 67.25 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 0.25 5" />
                            <Vertex pos="-1.75 0.25 -7" />
                            <Vertex pos="-1.75 -0.25 5" />
                            <Vertex pos="-1.75 -0.25 -7" />
                            <Vertex pos="-2.25 0.25 5" />
                            <Vertex pos="-2.25 0.25 -7" />
                            <Vertex pos="-2.25 -0.25 5" />
                            <Vertex pos="-2.25 -0.25 -7" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -5" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -7" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-8.75 69 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 69 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 2 -1.75" />
                            <Vertex pos="-1.75 2 -2.25" />
                            <Vertex pos="-1.75 -2 -1.75" />
                            <Vertex pos="-1.75 -2 -2.25" />
                            <Vertex pos="-2.25 2 -1.75" />
                            <Vertex pos="-2.25 2 -2.25" />
                            <Vertex pos="-2.25 -2 -1.75" />
                            <Vertex pos="-2.25 -2 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="-12 71.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 71.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 -1.75" />
                            <Vertex pos="1.5 0.25 -2.25" />
                            <Vertex pos="1.5 -0.25 -1.75" />
                            <Vertex pos="1.5 -0.25 -2.25" />
                            <Vertex pos="-3.5 0.25 -1.75" />
                            <Vertex pos="-3.5 0.25 -2.25" />
                            <Vertex pos="-3.5 -0.25 -1.75" />
                            <Vertex pos="-3.5 -0.25 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="-5 62.75 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 62.75 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="-5.75 67.25 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -5.75 0 1 0 67.25 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 0.25 0.25" />
                            <Vertex pos="2.75 0.25 -0.25" />
                            <Vertex pos="2.75 -0.25 0.25" />
                            <Vertex pos="2.75 -0.25 -0.25" />
                            <Vertex pos="-4.75 0.25 0.25" />
                            <Vertex pos="-4.75 0.25 -0.25" />
                            <Vertex pos="-4.75 -0.25 0.25" />
                            <Vertex pos="-4.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1088 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -576 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1088 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="5 65.125 6.375" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 65.125 0 0 1 6.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.125 2.125" />
                            <Vertex pos="8 0.125 1.625" />
                            <Vertex pos="8 -0.125 2.375" />
                            <Vertex pos="8 -0.125 1.625" />
                            <Vertex pos="-8 0.125 -1.875" />
                            <Vertex pos="-8 0.125 -2.375" />
                            <Vertex pos="-8 -0.125 -1.625" />
                            <Vertex pos="-8 -0.125 -2.375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -8" album="Blasted" material="bm_wood" texgens="0 1 0 16672 0 0 -1 -1632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_wood" texgens="0 -1 0 -16672 0 0 -1 -1632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -3840 0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -3840 0 0 -1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174078 0.696311 0.696311 -0.174078" album="" material="bm_stripe_caution1" texgens="1 0 1 2528 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.363804" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -3840 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="5 64.875 6.375" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 64.875 0 0 1 6.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8 0.125 2.375" />
                            <Vertex pos="8 0.125 1.625" />
                            <Vertex pos="8 -0.125 2.12499" />
                            <Vertex pos="8 -0.125 1.625" />
                            <Vertex pos="-8 0.125 -1.625" />
                            <Vertex pos="-8 0.125 -2.375" />
                            <Vertex pos="-8 -0.125 -1.87501" />
                            <Vertex pos="-8 -0.125 -2.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -8" album="Blasted" material="bm_wood" texgens="0 1 0 16608 0 0 -1 -1632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_wood" texgens="0 -1 0 -16608 0 0 -1 -1632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -3840 0 0 -1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -3840 0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.174074 -0.696325 0.696297 -0.174071" album="" material="bm_stripe_caution1" texgens="1 0 1 2528 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -0.363804" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -3840 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-13 -11.875 37.875" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -11.875 0 0 1 37.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.375" />
                            <Vertex pos="2 0.125 -0.875" />
                            <Vertex pos="2 -0.125001 -0.125" />
                            <Vertex pos="2 -0.125 -0.875" />
                            <Vertex pos="-2 0.125 0.625" />
                            <Vertex pos="-2 0.125 0.125" />
                            <Vertex pos="-2 -0.125001 0.875" />
                            <Vertex pos="-2 -0.125 0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3040 0 0 -1 -9696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3040 0 0 -1 -9696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-3.32793e-007 -1 -1.33117e-006 -0.125001" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696309 0.696312 -0.174078" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.363803" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-13 -12.125 37.875" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -12.125 0 0 1 37.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.124999 -0.125" />
                            <Vertex pos="2 0.125 -0.874996" />
                            <Vertex pos="2 -0.125 -0.374996" />
                            <Vertex pos="2 -0.125 -0.874996" />
                            <Vertex pos="-2 0.124999 0.875" />
                            <Vertex pos="-2 0.125 0.125004" />
                            <Vertex pos="-2 -0.125 0.625004" />
                            <Vertex pos="-2 -0.125 0.125004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3104 0 0 -1 -9696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3104 0 0 -1 -9696 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="3.32794e-007 1 1.33118e-006 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174079 -0.696306 0.696315 -0.17408" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.3638" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="19.25 67.25 7.75" rot="1 0 0 0" scale="" transform="1 0 0 19.25 0 1 0 67.25 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -6.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1472 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1472 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1472 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="16.75 62.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 16.75 0 1 0 62.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="26.5 67.25 13.75" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 67.25 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="25.25 67.25 11" rot="1 0 0 0" scale="" transform="1 0 0 25.25 0 1 0 67.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="27.25 60 13.75" rot="1 0 0 0" scale="" transform="1 0 0 27.25 0 1 0 60 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 -7 0.25" />
                            <Vertex pos="0.25 -7 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 -7 0.25" />
                            <Vertex pos="-0.25 -7 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="20.75 60 13.75" rot="1 0 0 0" scale="" transform="1 0 0 20.75 0 1 0 60 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="20.75 62.75 10.5" rot="1 0 0 0" scale="" transform="1 0 0 20.75 0 1 0 62.75 0 0 1 10.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 -0.25 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="22.75 55 13.75" rot="1 0 0 0" scale="" transform="1 0 0 22.75 0 1 0 55 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="21.5 56.75 13.75" rot="1 0 0 0" scale="" transform="1 0 0 21.5 0 1 0 56.75 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="31 43.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 43.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="31 38.75 17.75" rot="1 0 0 0" scale="" transform="1 0 0 31 0 1 0 38.75 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="33.25 41 17.75" rot="1 0 0 0" scale="" transform="1 0 0 33.25 0 1 0 41 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.5 0.25" />
                            <Vertex pos="0.25 2.5 -0.25" />
                            <Vertex pos="0.25 -2.5 0.25" />
                            <Vertex pos="0.25 -2.5 -0.25" />
                            <Vertex pos="-0.25 2.5 0.25" />
                            <Vertex pos="-0.25 2.5 -0.25" />
                            <Vertex pos="-0.25 -2.5 0.25" />
                            <Vertex pos="-0.25 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="0.25 43.25 23.75" rot="1 0 0 0" scale="" transform="1 0 0 0.25 0 1 0 43.25 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.75 0.25 0.25" />
                            <Vertex pos="6.75 0.25 -0.25" />
                            <Vertex pos="6.75 -0.25 0.25" />
                            <Vertex pos="6.75 -0.25 -0.25" />
                            <Vertex pos="-6.75 0.25 0.25" />
                            <Vertex pos="-6.75 0.25 -0.25" />
                            <Vertex pos="-6.75 -0.25 0.25" />
                            <Vertex pos="-6.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1600 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1600 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="0 38.75 23.75" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 38.75 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="7.125 41 23.75" rot="1 0 0 0" scale="" transform="1 0 0 7.125 0 1 0 41 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 0.25" />
                            <Vertex pos="0.125 2.5 -0.25" />
                            <Vertex pos="0.125 -2.5 0.25" />
                            <Vertex pos="0.125 -2.5 -0.25" />
                            <Vertex pos="-0.125 2.5 0.25" />
                            <Vertex pos="-0.125 2.5 -0.25" />
                            <Vertex pos="-0.125 -2.5 0.25" />
                            <Vertex pos="-0.125 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_trim" texgens="-1 0 0 1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_trim" texgens="1 0 0 -1120 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1120 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 1248 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="-6.75 51.25 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 51.25 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 19.75 0.25" />
                            <Vertex pos="0.25 19.75 -0.25" />
                            <Vertex pos="0.25 -8.25 0.25" />
                            <Vertex pos="0.25 -8.25 -0.25" />
                            <Vertex pos="-0.25 19.75 0.25" />
                            <Vertex pos="-0.25 19.75 -0.25" />
                            <Vertex pos="-0.25 -8.25 0.25" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -4928 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -19.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="-6.75 49 28.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 49 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.5 0.25" />
                            <Vertex pos="0.25 10.5 -0.25" />
                            <Vertex pos="0.25 -10.5 0.25" />
                            <Vertex pos="0.25 -10.5 -0.25" />
                            <Vertex pos="-0.25 10.5 0.25" />
                            <Vertex pos="-0.25 10.5 -0.25" />
                            <Vertex pos="-0.25 -10.5 0.25" />
                            <Vertex pos="-0.25 -10.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2560 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="-6.75 38.75 26" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 38.75 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="-6.75 59.25 26" rot="1 0 0 0" scale="" transform="1 0 0 -6.75 0 1 0 59.25 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="-19.25 49.25 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 49.25 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.25 0.25" />
                            <Vertex pos="0.25 10.25 -0.25" />
                            <Vertex pos="0.25 -10.25 0.25" />
                            <Vertex pos="0.25 -10.25 -0.25" />
                            <Vertex pos="-0.25 10.25 0.25" />
                            <Vertex pos="-0.25 10.25 -0.25" />
                            <Vertex pos="-0.25 -10.25 0.25" />
                            <Vertex pos="-0.25 -10.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="-19.25 49.25 28.25" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 49.25 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 10.25 0.25" />
                            <Vertex pos="0.25 10.25 -0.25" />
                            <Vertex pos="0.25 -10.25 0.25" />
                            <Vertex pos="0.25 -10.25 -0.25" />
                            <Vertex pos="-0.25 10.25 0.25" />
                            <Vertex pos="-0.25 10.25 -0.25" />
                            <Vertex pos="-0.25 -10.25 0.25" />
                            <Vertex pos="-0.25 -10.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -2496 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -10.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2624 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="-19.25 59.25 26" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 59.25 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="-19.25 33 27.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 33 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="-17.25 30.75 27.75" rot="1 0 0 0" scale="" transform="1 0 0 -17.25 0 1 0 30.75 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="-19.25 34.75 25.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.25 0 1 0 34.75 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 1.75" />
                            <Vertex pos="0.25 0.25 -1.75" />
                            <Vertex pos="0.25 -0.25 1.75" />
                            <Vertex pos="0.25 -0.25 -1.75" />
                            <Vertex pos="-0.25 0.25 1.75" />
                            <Vertex pos="-0.25 0.25 -1.75" />
                            <Vertex pos="-0.25 -0.25 1.75" />
                            <Vertex pos="-0.25 -0.25 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="-52 39.25 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -52 0 1 0 39.25 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -7" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1664 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="-55.25 34.75 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -55.25 0 1 0 34.75 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="-59.125 37 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -59.125 0 1 0 37 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 0.25" />
                            <Vertex pos="0.125 2.5 -0.25" />
                            <Vertex pos="0.125 -2.5 0.25" />
                            <Vertex pos="0.125 -2.5 -0.25" />
                            <Vertex pos="-0.125 2.5 0.25" />
                            <Vertex pos="-0.125 2.5 -0.25" />
                            <Vertex pos="-0.125 -2.5 0.25" />
                            <Vertex pos="-0.125 -2.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.125" album="" material="bm_trim" texgens="0 1 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="" material="bm_trim" texgens="0 -1 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="" material="bm_trim" texgens="-1 0 0 1184 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_trim" texgens="1 0 0 -1056 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -1056 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 1184 0 -1 0 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="-44.75 34 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -44.75 0 1 0 34 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="-51.25 34 17.75" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 34 0 0 1 17.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="-51.25 21.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -51.25 0 1 0 21.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 -3.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="-48 18.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -48 0 1 0 18.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="-33.75 25.25 25.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.75 0 1 0 25.25 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="-30.75 22 25.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 22 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="-33.875 16.5 27.125" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 16.5 0 0 1 27.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 -0.625002" />
                            <Vertex pos="0.125 2.5 -1.125" />
                            <Vertex pos="0.125 -2.5 0.874998" />
                            <Vertex pos="0.125 -2.5 0.375002" />
                            <Vertex pos="-0.125 2.5 -0.375002" />
                            <Vertex pos="-0.125 2.5 -1.125" />
                            <Vertex pos="-0.125 -2.5 1.125" />
                            <Vertex pos="-0.125 -2.5 0.375002" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -1024 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -1024 0 0 -1 576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8672 0 0 -1 -6944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8672 0 0 -1 -6944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.691714 0.207515 0.691714 -0.172928" album="" material="bm_stripe_caution1" texgens="1 -1 0 672 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.287348 -0.957826 -0.359184" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 64 0 -1 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="-34.125 16.5 27.125" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 16.5 0 0 1 27.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 -0.374992" />
                            <Vertex pos="0.125 2.5 -1.12501" />
                            <Vertex pos="0.125 -2.5 1.12501" />
                            <Vertex pos="0.125 -2.5 0.374994" />
                            <Vertex pos="-0.125 2.5 -0.624992" />
                            <Vertex pos="-0.125 2.5 -1.12501" />
                            <Vertex pos="-0.125 -2.5 0.875006" />
                            <Vertex pos="-0.125 -2.5 0.374994" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -1024 0 0 -1 576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -1024 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8736 0 0 -1 -6944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8736 0 0 -1 -6944 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.691715 0.207514 0.691715 -0.172933" album="" material="bm_stripe_caution1" texgens="1 1 0 -480 0 -1 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.287349 -0.957826 -0.359192" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="-33.875 1.5 31.625" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 1.5 0 0 1 31.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 -0.625" />
                            <Vertex pos="0.125 2.5 -1.125" />
                            <Vertex pos="0.125 -2.5 0.875" />
                            <Vertex pos="0.125 -2.5 0.375004" />
                            <Vertex pos="-0.125 2.5 -0.375" />
                            <Vertex pos="-0.125 2.5 -1.125" />
                            <Vertex pos="-0.125 -2.5 1.125" />
                            <Vertex pos="-0.125 -2.5 0.375004" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -1024 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -1024 0 0 -1 576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8672 0 0 -1 -8096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8672 0 0 -1 -8096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.691715 0.207514 0.691715 -0.172929" album="" material="bm_stripe_caution1" texgens="1 -1 0 928 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.287349 -0.957826 -0.359183" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 64 0 -1 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="-34.125 1.5 31.625" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 1.5 0 0 1 31.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2.5 -0.374996" />
                            <Vertex pos="0.125 2.5 -1.12501" />
                            <Vertex pos="0.125 -2.5 1.12501" />
                            <Vertex pos="0.125 -2.5 0.374996" />
                            <Vertex pos="-0.125 2.5 -0.624996" />
                            <Vertex pos="-0.125 2.5 -1.12501" />
                            <Vertex pos="-0.125 -2.5 0.875008" />
                            <Vertex pos="-0.125 -2.5 0.374996" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -1024 0 0 -1 576 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -1024 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8736 0 0 -1 -8096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8736 0 0 -1 -8096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.691714 0.207515 0.691714 -0.172933" album="" material="bm_stripe_caution1" texgens="1 1 0 -736 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.287349 -0.957826 -0.359191" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 1280 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="-33.875 12.5 28.825" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 12.5 0 0 1 28.825 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 1.5 0.175001" />
                            <Vertex pos="0.125 1.5 -1.325" />
                            <Vertex pos="-0.125 1.5 0.424999" />
                            <Vertex pos="-0.125 1.5 -1.325" />
                            <Vertex pos="0.125 -1.5 1.075" />
                            <Vertex pos="0.125 -1.5 -0.425001" />
                            <Vertex pos="-0.125 -1.5 1.325" />
                            <Vertex pos="-0.125 -1.5 -0.425001" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8672 0 0 -1 -7379.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 0 0 -0.3 -1 106.667 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 678.5 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0.691711 0.207515 0.691717 -0.518788" album="" material="bm_stripe_caution1" texgens="1 -1 0 -352 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0.287348 -0.957826 -0.838099" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 64 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8672 0 0 1 7379.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="-34.125 12.5 28.825" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 12.5 0 0 1 28.825 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 1.5 0.425001" />
                            <Vertex pos="0.125 1.5 -1.325" />
                            <Vertex pos="-0.125 1.5 0.174999" />
                            <Vertex pos="-0.125 1.5 -1.325" />
                            <Vertex pos="0.125 -1.5 1.325" />
                            <Vertex pos="0.125 -1.5 -0.424999" />
                            <Vertex pos="-0.125 -1.5 1.075" />
                            <Vertex pos="-0.125 -1.5 -0.424999" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8736 0 0 -1 -7379.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 678.5 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 0 0 -0.3 -1 106.667 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0.691717 0.207514 0.691712 -0.518784" album="" material="bm_stripe_caution1" texgens="1 1 0 544 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0.287348 -0.957826 -0.838098" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8736 0 0 1 7379.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="-33.875 9 29.375" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 9 0 0 1 29.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 -0.475" />
                            <Vertex pos="0.125 2 -0.975" />
                            <Vertex pos="-0.125 2 -0.225" />
                            <Vertex pos="-0.125 2 -0.975" />
                            <Vertex pos="0.125 -2 0.725" />
                            <Vertex pos="0.125 -2 0.225" />
                            <Vertex pos="-0.125 -2 0.975" />
                            <Vertex pos="-0.125 -2 0.225" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 1 499 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -768 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -768 0 0 -1 499 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0.691714 0.207514 0.691714 -0.172929" album="" material="bm_stripe_caution1" texgens="1 -1 0 544 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0.287348 -0.957826 -0.359185" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 64 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 1 -115 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="-33.875 5.5 30.925" rot="1 0 0 0" scale="" transform="1 0 0 -33.875 0 1 0 5.5 0 0 1 30.925 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 -1.5 1.075" />
                            <Vertex pos="0.125 -1.5 -0.424999" />
                            <Vertex pos="-0.125 -1.5 1.325" />
                            <Vertex pos="-0.125 -1.5 -0.424999" />
                            <Vertex pos="0.125 1.5 0.175001" />
                            <Vertex pos="0.125 1.5 -1.325" />
                            <Vertex pos="-0.125 1.5 0.425001" />
                            <Vertex pos="-0.125 1.5 -1.325" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8672 0 0 -1 -7916.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 0 0 -0.3 -1 106.667 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -512 0 0 -1 678.5 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.691714 0.207514 0.691714 -0.518786" album="" material="bm_stripe_caution1" texgens="1 -1 0 1440 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.287348 -0.957826 -0.838098" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 64 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8672 0 0 1 7916.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="287" owner="0" type="0" pos="-34.125 9 29.375" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 9 0 0 1 29.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 2 -0.224997" />
                            <Vertex pos="0.125 2 -0.975002" />
                            <Vertex pos="-0.125 2 -0.474998" />
                            <Vertex pos="-0.125 2 -0.975002" />
                            <Vertex pos="0.125 -2 0.975" />
                            <Vertex pos="0.125 -2 0.224998" />
                            <Vertex pos="-0.125 -2 0.725" />
                            <Vertex pos="-0.125 -2 0.224998" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 1 499 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -768 0 0 -1 499 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 -768 0 -0.3 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0.691716 0.207514 0.691713 -0.172929" album="" material="bm_stripe_caution1" texgens="1 1 0 -352 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0.287348 -0.957826 -0.359187" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 1024 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 0 1 -115 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="288" owner="0" type="0" pos="-34.125 5.5 30.925" rot="1 0 0 0" scale="" transform="1 0 0 -34.125 0 1 0 5.5 0 0 1 30.925 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 -1.5 1.325" />
                            <Vertex pos="0.125 -1.5 -0.424999" />
                            <Vertex pos="-0.125 -1.5 1.075" />
                            <Vertex pos="-0.125 -1.5 -0.424999" />
                            <Vertex pos="0.125 1.5 0.425001" />
                            <Vertex pos="0.125 1.5 -1.325" />
                            <Vertex pos="-0.125 1.5 0.175001" />
                            <Vertex pos="-0.125 1.5 -1.325" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -1.5" album="Blasted" material="bm_wood" texgens="1 0 0 -8736 0 0 -1 -7916.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 -512 0 0 -1 678.5 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 0 0 -0.3 -1 106.667 0 0.1875 0.1875" texRot="0" texScale="0.1875 0.1875" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.691714 0.207514 0.691714 -0.518786" album="" material="bm_stripe_caution1" texgens="1 1 0 -1248 0 -1 0 1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.287348 -0.957826 -0.838098" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 192 0 -1 0 768 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -1.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8736 0 0 1 7916.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="289" owner="0" type="0" pos="-43.25 -3 31.75" rot="1 0 0 0" scale="" transform="1 0 0 -43.25 0 1 0 -3 0 0 1 31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="290" owner="0" type="0" pos="-30.75 -4.75 31.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 -4.75 0 0 1 31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3.75 0.25" />
                            <Vertex pos="0.25 3.75 -0.25" />
                            <Vertex pos="0.25 -3.75 0.25" />
                            <Vertex pos="0.25 -3.75 -0.25" />
                            <Vertex pos="-0.25 3.75 0.25" />
                            <Vertex pos="-0.25 3.75 -0.25" />
                            <Vertex pos="-0.25 -3.75 0.25" />
                            <Vertex pos="-0.25 -3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="291" owner="0" type="0" pos="-40.25 -0.75 31.75" rot="1 0 0 0" scale="" transform="1 0 0 -40.25 0 1 0 -0.75 0 0 1 31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.25 0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -704 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="292" owner="0" type="0" pos="-43.25 -13.25 33.75" rot="1 0 0 0" scale="" transform="1 0 0 -43.25 0 1 0 -13.25 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -1984 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -8.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 2112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="293" owner="0" type="0" pos="-43.25 -5.25 32.5" rot="1 0 0 0" scale="" transform="1 0 0 -43.25 0 1 0 -5.25 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="294" owner="0" type="0" pos="-30.75 -8.75 33.5" rot="1 0 0 0" scale="" transform="1 0 0 -30.75 0 1 0 -8.75 0 0 1 33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="295" owner="0" type="0" pos="-27 -8.75 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -8.75 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="296" owner="0" type="0" pos="-19 -8.75 37.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -8.75 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="297" owner="0" type="0" pos="-22.75 -8.75 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -22.75 0 1 0 -8.75 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="298" owner="0" type="0" pos="-17 -15.25 37.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -15.25 0 0 1 37.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 -0.25 0.25" />
                            <Vertex pos="2 -0.25 -0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 -0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="299" owner="0" type="0" pos="-18.75 -15.25 36.5" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 -15.25 0 0 1 36.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="300" owner="0" type="0" pos="-18.75 -18.5 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.75 0 1 0 -18.5 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="301" owner="0" type="0" pos="-27 -21.25 35.75" rot="1 0 0 0" scale="" transform="1 0 0 -27 0 1 0 -21.25 0 0 1 35.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -8" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1920 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1920 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="-34.75 -21.25 34.5" rot="1 0 0 0" scale="" transform="1 0 0 -34.75 0 1 0 -21.25 0 0 1 34.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="-39 -21.25 33.75" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -21.25 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -896 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="-5 -11.875 35.875" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -11.875 0 0 1 35.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.375" />
                            <Vertex pos="2 0.125 -0.874996" />
                            <Vertex pos="2 -0.125001 -0.125" />
                            <Vertex pos="2 -0.125 -0.874996" />
                            <Vertex pos="-2 0.125 0.625" />
                            <Vertex pos="-2 0.125 0.125004" />
                            <Vertex pos="-2 -0.125001 0.875" />
                            <Vertex pos="-2 -0.125 0.125004" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3040 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3040 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-3.32794e-007 -1 -1.33118e-006 -0.125001" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696309 0.696312 -0.174078" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.3638" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="-5 -12.125 35.875" rot="1 0 0 0" scale="" transform="1 0 0 -5 0 1 0 -12.125 0 0 1 35.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.124999 -0.125" />
                            <Vertex pos="2 0.125 -0.874996" />
                            <Vertex pos="2 -0.125 -0.374996" />
                            <Vertex pos="2 -0.125 -0.874996" />
                            <Vertex pos="-2 0.124999 0.875" />
                            <Vertex pos="-2 0.125 0.125004" />
                            <Vertex pos="-2 -0.125 0.625004" />
                            <Vertex pos="-2 -0.125 0.125004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3104 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3104 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="3.32794e-007 1 1.33118e-006 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174079 -0.696306 0.696315 -0.17408" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.3638" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="306" owner="0" type="0" pos="-9 -11.875 37.375" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -11.875 0 0 1 37.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.125" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125001 0.375" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.125 1.125" />
                            <Vertex pos="-2 0.125 -0.375" />
                            <Vertex pos="-2 -0.125001 1.375" />
                            <Vertex pos="-2 -0.125 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3040 0 0 -1 -9568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3040 0 0 -1 -9568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-1.42625e-007 -1 -5.70502e-007 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696309 0.696312 -0.522234" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.848875" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-9 -12.125 37.375" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 -12.125 0 0 1 37.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.124999 0.375" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125 0.125" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.124999 1.375" />
                            <Vertex pos="-2 0.125 -0.375" />
                            <Vertex pos="-2 -0.125 1.125" />
                            <Vertex pos="-2 -0.125 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -3104 0 0 -1 -9568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 3104 0 0 -1 -9568 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="1.42625e-007 1 5.70502e-007 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174077 -0.696312 0.696309 -0.522232" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.848875" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="-3 -19.875 35.875" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -19.875 0 0 1 35.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.125" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125 0.375" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.125 1.125" />
                            <Vertex pos="-2 0.125 -0.375" />
                            <Vertex pos="-2 -0.125 1.375" />
                            <Vertex pos="-2 -0.125 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5088 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5088 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696311 0.696311 -0.522233" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.848875" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="309" owner="0" type="0" pos="-3 -20.125 35.875" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 -20.125 0 0 1 35.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.375" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125 0.125" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.125 1.375" />
                            <Vertex pos="-2 0.125 -0.375004" />
                            <Vertex pos="-2 -0.125 1.125" />
                            <Vertex pos="-2 -0.125 -0.375004" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5152 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5152 0 0 -1 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 -0.696311 0.696311 -0.522233" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242535 0 -0.970143 -0.848877" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="310" owner="0" type="0" pos="5 -19.875 33.875" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -19.875 0 0 1 33.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.124996" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125 0.375" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.125 1.125" />
                            <Vertex pos="-2 0.125 -0.375" />
                            <Vertex pos="-2 -0.125 1.375" />
                            <Vertex pos="-2 -0.125 -0.375" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5088 0 0 -1 -8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5088 0 0 -1 -8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696311 0.696311 -0.522232" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.848875" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="5 -20.125 33.875" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 -20.125 0 0 1 33.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 0.374996" />
                            <Vertex pos="2 0.125 -1.375" />
                            <Vertex pos="2 -0.125 0.124996" />
                            <Vertex pos="2 -0.125 -1.375" />
                            <Vertex pos="-2 0.125 1.375" />
                            <Vertex pos="-2 0.125 -0.374996" />
                            <Vertex pos="-2 -0.125 1.125" />
                            <Vertex pos="-2 -0.125 -0.374996" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5152 0 0 -1 -8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5152 0 0 -1 -8672 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 704 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -256 -0.25 0 -1 106.667 0 0.125 0.1875" texRot="0" texScale="0.125 0.1875" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 -0.696311 0.696311 -0.522232" album="" material="bm_stripe_caution1" texgens="1 0 1 480 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242537 0 -0.970142 -0.848873" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="1 -19.875 34.375" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -19.875 0 0 1 34.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.375" />
                            <Vertex pos="2 0.125 -0.874996" />
                            <Vertex pos="2 -0.125 -0.125" />
                            <Vertex pos="2 -0.125 -0.874996" />
                            <Vertex pos="-2 0.125 0.625" />
                            <Vertex pos="-2 0.125 0.125004" />
                            <Vertex pos="-2 -0.125 0.875" />
                            <Vertex pos="-2 -0.125 0.125004" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5088 0 0 -1 -8800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5088 0 0 -1 -8800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 0.696311 0.696311 -0.174078" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.3638" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="313" owner="0" type="0" pos="1 -20.125 34.375" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 -20.125 0 0 1 34.375 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.125 -0.125" />
                            <Vertex pos="2 0.125 -0.875" />
                            <Vertex pos="2 -0.125 -0.375" />
                            <Vertex pos="2 -0.125 -0.875" />
                            <Vertex pos="-2 0.125 0.875" />
                            <Vertex pos="-2 0.125 0.125" />
                            <Vertex pos="-2 -0.125 0.625" />
                            <Vertex pos="-2 -0.125 0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_wood" texgens="0 1 0 -5152 0 0 -1 -8800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_wood" texgens="0 -1 0 5152 0 0 -1 -8800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 0 -1 448 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 -768 -0.25 0 -1 64 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 -0.696311 0.696311 -0.174078" album="" material="bm_stripe_caution1" texgens="1 0 1 352 0 -1 0 32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.363803" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 -768 0 -1 0 192 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="314" owner="0" type="0" pos="12 -23.25 31.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -23.25 0 0 1 31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="315" owner="0" type="0" pos="15.25 -21.25 31.75" rot="1 0 0 0" scale="" transform="1 0 0 15.25 0 1 0 -21.25 0 0 1 31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2.25 0.25" />
                            <Vertex pos="0.25 2.25 -0.25" />
                            <Vertex pos="0.25 -2.25 0.25" />
                            <Vertex pos="0.25 -2.25 -0.25" />
                            <Vertex pos="-0.25 2.25 0.25" />
                            <Vertex pos="-0.25 2.25 -0.25" />
                            <Vertex pos="-0.25 -2.25 0.25" />
                            <Vertex pos="-0.25 -2.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 576 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="316" owner="0" type="0" pos="14 -21 26" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -21 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 6" />
                            <Vertex pos="1 2 -4" />
                            <Vertex pos="1 -2 6" />
                            <Vertex pos="1 -2 -4" />
                            <Vertex pos="-1 2 6" />
                            <Vertex pos="-1 2 -6" />
                            <Vertex pos="-1 -2 6" />
                            <Vertex pos="-1 -2 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_tile05_C" texgens="1 0 0 3840 0 -1 0 5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="317" owner="0" type="0" pos="6 7.25 25.75" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 7.25 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="318" owner="0" type="0" pos="8.5 0.75 25.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 0.75 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="319" owner="0" type="0" pos="5.25 -3.25 25.75" rot="1 0 0 0" scale="" transform="1 0 0 5.25 0 1 0 -3.25 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="320" owner="0" type="0" pos="7.25 -1 25.75" rot="1 0 0 0" scale="" transform="1 0 0 7.25 0 1 0 -1 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="321" owner="0" type="0" pos="9.25 4 25.75" rot="1 0 0 0" scale="" transform="1 0 0 9.25 0 1 0 4 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="1.5 1.25 25.75" rot="1 0 0 0" scale="" transform="1 0 0 1.5 0 1 0 1.25 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="323" owner="0" type="0" pos="2.75 4 25.75" rot="1 0 0 0" scale="" transform="1 0 0 2.75 0 1 0 4 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="324" owner="0" type="0" pos="0.75 0 25.75" rot="1 0 0 0" scale="" transform="1 0 0 0.75 0 1 0 0 0 0 1 25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="325" owner="0" type="0" pos="-42 8 15" rot="1 0 0 0" scale="" transform="1 0 0 -42 0 1 0 8 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 -1.5" />
                            <Vertex pos="1 3 -2" />
                            <Vertex pos="1 -3 2" />
                            <Vertex pos="1 -3 1.5" />
                            <Vertex pos="-1 3 -1.5" />
                            <Vertex pos="-1 3 -2" />
                            <Vertex pos="-1 -3 2" />
                            <Vertex pos="-1 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10496 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="326" owner="0" type="0" pos="-40.75 8 15" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 8 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -1.5" />
                            <Vertex pos="0.25 3 -2" />
                            <Vertex pos="0.25 -3 2" />
                            <Vertex pos="0.25 -3 1.5" />
                            <Vertex pos="-0.25 3 -1.5" />
                            <Vertex pos="-0.25 3 -2" />
                            <Vertex pos="-0.25 -3 2" />
                            <Vertex pos="-0.25 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 -0.583333 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="327" owner="0" type="0" pos="-45.25 8 15" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 8 0 0 1 15 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 -1.5" />
                            <Vertex pos="0.25 3 -2" />
                            <Vertex pos="0.25 -3 2" />
                            <Vertex pos="0.25 -3 1.5" />
                            <Vertex pos="-0.25 3 -1.5" />
                            <Vertex pos="-0.25 3 -2" />
                            <Vertex pos="-0.25 -3 2" />
                            <Vertex pos="-0.25 -3 1.5" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 -0.583333 -1 64.0002 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.503871 0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.503871 -0.863779 -0.215945" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="-46.5 5.25 16.6042" rot="1 0 0 0" scale="" transform="1 0 0 -46.5 0 1 0 5.25 0 0 1 16.6042 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -0.25 0.39583" />
                            <Vertex pos="1 -0.25 -0.104172" />
                            <Vertex pos="-1 -0.25 0.39583" />
                            <Vertex pos="-1 -0.25 -0.104172" />
                            <Vertex pos="1 0.25 0.104174" />
                            <Vertex pos="1 0.25 -0.395828" />
                            <Vertex pos="-1 0.25 0.104174" />
                            <Vertex pos="-1 0.25 -0.395828" />
                        </Vertices>
                        <Face id="0" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 101.344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 101.344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-1 -0 -0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 -0.583333 -1 64.0019 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 0.503857 0.863787 -0.215948" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 -0.503857 -0.863787 -0.215947" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 26.6685 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="329" owner="0" type="0" pos="-41.5 4.75 16.8958" rot="1 0 0 0" scale="" transform="1 0 0 -41.5 0 1 0 4.75 0 0 1 16.8958 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.104174" />
                            <Vertex pos="1 0.25 -0.395828" />
                            <Vertex pos="-1 0.25 0.104174" />
                            <Vertex pos="-1 0.25 -0.395828" />
                            <Vertex pos="1 -0.25 0.39583" />
                            <Vertex pos="1 -0.25 -0.104172" />
                            <Vertex pos="-1 -0.25 0.39583" />
                            <Vertex pos="-1 -0.25 -0.104172" />
                        </Vertices>
                        <Face id="0" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 26.6875 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 -0.583333 -1 64.0019 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 101.313 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0 0.503857 0.863787 -0.215948" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0.503857 -0.863787 -0.215947" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 101.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="330" owner="0" type="0" pos="-48.75 -22.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -48.75 0 1 0 -22.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.75 0.25" />
                            <Vertex pos="0.25 1.75 -0.25" />
                            <Vertex pos="0.25 -1.75 0.25" />
                            <Vertex pos="0.25 -1.75 -0.25" />
                            <Vertex pos="-0.25 1.75 0.25" />
                            <Vertex pos="-0.25 1.75 -0.25" />
                            <Vertex pos="-0.25 -1.75 0.25" />
                            <Vertex pos="-0.25 -1.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 5824 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 12480 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -12480 0 -1 0 5824 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="331" owner="0" type="0" pos="-48.75 -25.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -48.75 0 1 0 -25.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1.25 0.25" />
                            <Vertex pos="0.25 1.25 -0.25" />
                            <Vertex pos="0.25 -1.25 0.25" />
                            <Vertex pos="0.25 -1.25 -0.25" />
                            <Vertex pos="-0.25 1.25 0.25" />
                            <Vertex pos="-0.25 1.25 -0.25" />
                            <Vertex pos="-0.25 -1.25 0.25" />
                            <Vertex pos="-0.25 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 6592 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 -12480 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -12480 0 -1 0 6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="332" owner="0" type="0" pos="-47.5 -25.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -47.5 0 1 0 -25.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -0.749998 0.25" />
                            <Vertex pos="1 -0.749998 -0.25" />
                            <Vertex pos="1 -1.25 0.25" />
                            <Vertex pos="1 -1.25 -0.25" />
                            <Vertex pos="-1 1.25 0.25" />
                            <Vertex pos="-1 1.25 -0.25" />
                            <Vertex pos="-1 -1.25 0.25" />
                            <Vertex pos="-1 -1.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707106 0.707107 -0 -0.176777" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1.25" album="Blasted" material="bm_wood" texgens="1 0 0 -12160 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -12160 0 -1 0 6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="333" owner="0" type="0" pos="-44.75 -26.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -44.75 0 1 0 -26.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.75 0.25 0.25" />
                            <Vertex pos="1.75 0.25 -0.25" />
                            <Vertex pos="1.75 -0.25 0.25" />
                            <Vertex pos="1.75 -0.25 -0.25" />
                            <Vertex pos="-1.75 0.25 0.25" />
                            <Vertex pos="-1.75 0.25 -0.25" />
                            <Vertex pos="-1.75 -0.25 0.25" />
                            <Vertex pos="-1.75 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.75" album="Blasted" material="bm_wood" texgens="0 1 0 -6848 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -11456 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -11456 0 -1 0 6848 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -320 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="334" owner="0" type="0" pos="-47.75 -21.25 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -47.75 0 1 0 -21.25 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 0.25 0.249998" />
                            <Vertex pos="-0.75 0.25 -0.25" />
                            <Vertex pos="-0.75 -0.25 0.249998" />
                            <Vertex pos="-0.75 -0.25 -0.25" />
                            <Vertex pos="0.749996 0.25 -0.25" />
                            <Vertex pos="0.749996 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 1 0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 12224 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 3 2" />
                        </Face>
                        <Face id="3" plane="0.316227 -0 0.948683 1.59442e-006" album="Blasted" material="bm_wood" texgens="1 0 0 -12224 0 -1 0 5440 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 2 0 4" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="335" owner="0" type="0" pos="-43.25 -25.75 19.75" rot="1 0 0 0" scale="" transform="1 0 0 -43.25 0 1 0 -25.75 0 0 1 19.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -0.749996 0.25" />
                            <Vertex pos="0.25 -0.749996 -0.25" />
                            <Vertex pos="0.25 0.749998 -0.25" />
                            <Vertex pos="-0.25 -0.749996 0.25" />
                            <Vertex pos="-0.25 -0.749996 -0.25" />
                            <Vertex pos="-0.25 0.749998 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 1 0 -6592 0 0 -1 -5056 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 3 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.749996" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="3" plane="0 0.316229 0.948683 -2.98023e-007" album="Blasted" material="bm_wood" texgens="1 0 0 -11072 0 -1 0 6592 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                    </Brush>
                    <Brush id="336" owner="5" type="999" pos="-45 -16 21" rot="1 0 0 0" scale="" transform="1 0 0 -45 0 1 0 -16 0 0 1 21 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 1" />
                            <Vertex pos="2 1 -1" />
                            <Vertex pos="2 -1 1" />
                            <Vertex pos="2 -1 -1" />
                            <Vertex pos="-2 1 1" />
                            <Vertex pos="-2 1 -1" />
                            <Vertex pos="-2 -1 1" />
                            <Vertex pos="-2 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_stripe_caution1" texgens="0 -1 1 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="337" owner="9" type="999" pos="-38 -19 20" rot="1 0 0 0" scale="" transform="1 0 0 -38 0 1 0 -19 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_stripe_caution1" texgens="1 0 1 256 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="338" owner="13" type="999" pos="-32 -23 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 -23 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_grid_blank2" texgens="0 1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank2" texgens="0 -1 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_stripe_caution1" texgens="1 0 1 256 0 0 -1 -96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_grid_blank2" texgens="1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank2" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="411" owner="0" type="0" pos="-43 49 8" rot="1 0 0 0" scale="" transform="1 0 0 -43 0 1 0 49 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 1" />
                            <Vertex pos="2 2 0.499999" />
                            <Vertex pos="2 -2 -0.499999" />
                            <Vertex pos="2 -2 -1" />
                            <Vertex pos="-2 2 1" />
                            <Vertex pos="-2 2 0.499999" />
                            <Vertex pos="-2 -2 -0.499999" />
                            <Vertex pos="-2 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234083" album="Blasted" material="bm_tile06_C" texgens="1 0 0 -10752 0 -1 0 -12288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234083" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="412" owner="0" type="0" pos="-31.25 51 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.25 0 1 0 51 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="413" owner="0" type="0" pos="-29 48.75 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 48.75 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -512 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="414" owner="0" type="0" pos="-40.75 49 8" rot="1 0 0 0" scale="" transform="1 0 0 -40.75 0 1 0 49 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.25 2 0.499999" />
                            <Vertex pos="0.25 -2 -0.499999" />
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.25 2 1" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.499999" />
                            <Vertex pos="-0.25 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0.375 -1 64.0003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234083" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234083" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="-45.25 49 8" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 49 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.25 2 0.499999" />
                            <Vertex pos="0.25 -2 -0.499999" />
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.25 2 1" />
                            <Vertex pos="-0.25 2 0.499999" />
                            <Vertex pos="-0.25 -2 -0.499999" />
                            <Vertex pos="-0.25 -2 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -384 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0.375 -1 64.0003 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.351123 0.936329 -0.234083" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.351123 -0.936329 -0.234083" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="416" owner="0" type="0" pos="-45.25 43 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -45.25 0 1 0 43 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="441" owner="0" type="0" pos="-2.75 -43 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -43 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="442" owner="0" type="0" pos="-2.75 -47 4" rot="1 0 0 0" scale="" transform="1 0 0 -2.75 0 1 0 -47 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="443" owner="0" type="0" pos="-12 71.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 71.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -1.5" />
                            <Vertex pos="1 0.25 -2.5" />
                            <Vertex pos="1 -0.25 -1.5" />
                            <Vertex pos="1 -0.25 -2.5" />
                            <Vertex pos="-3 0.25 -1.5" />
                            <Vertex pos="-3 0.25 -2.5" />
                            <Vertex pos="-3 -0.25 -1.5" />
                            <Vertex pos="-3 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="444" owner="0" type="0" pos="-8.75 70 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 70 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 1 -1.5" />
                            <Vertex pos="-1.75 1 -2.5" />
                            <Vertex pos="-1.75 -1 -1.5" />
                            <Vertex pos="-1.75 -1 -2.5" />
                            <Vertex pos="-2.25 1 -1.5" />
                            <Vertex pos="-2.25 1 -2.5" />
                            <Vertex pos="-2.25 -1 -1.5" />
                            <Vertex pos="-2.25 -1 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="445" owner="0" type="0" pos="-15.25 70 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 70 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 -1.5" />
                            <Vertex pos="0.25 1 -2.5" />
                            <Vertex pos="0.25 -1 -1.5" />
                            <Vertex pos="0.25 -1 -2.5" />
                            <Vertex pos="-0.25 1 -1.5" />
                            <Vertex pos="-0.25 1 -2.5" />
                            <Vertex pos="-0.25 -1 -1.5" />
                            <Vertex pos="-0.25 -1 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="0 1 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="0 -1 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="446" owner="0" type="0" pos="-8.75 70 19.25" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 70 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 1 -1.75" />
                            <Vertex pos="-1.75 1 -2.25" />
                            <Vertex pos="-1.75 -1 -1.75" />
                            <Vertex pos="-1.75 -1 -2.25" />
                            <Vertex pos="-2.25 1 -1.75" />
                            <Vertex pos="-2.25 1 -2.25" />
                            <Vertex pos="-2.25 -1 -1.75" />
                            <Vertex pos="-2.25 -1 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="447" owner="0" type="0" pos="-15.25 70 19.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 70 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 -1.75" />
                            <Vertex pos="0.25 1 -2.25" />
                            <Vertex pos="0.25 -1 -1.75" />
                            <Vertex pos="0.25 -1 -2.25" />
                            <Vertex pos="-0.25 1 -1.75" />
                            <Vertex pos="-0.25 1 -2.25" />
                            <Vertex pos="-0.25 -1 -1.75" />
                            <Vertex pos="-0.25 -1 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="448" owner="0" type="0" pos="-12 71.25 19.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 71.25 0 0 1 19.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 -1.75" />
                            <Vertex pos="1.5 0.25 -2.25" />
                            <Vertex pos="1.5 -0.25 -1.75" />
                            <Vertex pos="1.5 -0.25 -2.25" />
                            <Vertex pos="-3.5 0.25 -1.75" />
                            <Vertex pos="-3.5 0.25 -2.25" />
                            <Vertex pos="-3.5 -0.25 -1.75" />
                            <Vertex pos="-3.5 -0.25 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="449" owner="0" type="0" pos="-8.75 71.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 71.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 0.25 -1.5" />
                            <Vertex pos="-1.75 0.25 -2.5" />
                            <Vertex pos="-1.75 -0.25 -1.5" />
                            <Vertex pos="-1.75 -0.25 -2.5" />
                            <Vertex pos="-2.25 0.25 -1.5" />
                            <Vertex pos="-2.25 0.25 -2.5" />
                            <Vertex pos="-2.25 -0.25 -1.5" />
                            <Vertex pos="-2.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="450" owner="0" type="0" pos="-15.25 71.25 18.5" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 71.25 0 0 1 18.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 -1.5" />
                            <Vertex pos="0.25 0.25 -2.5" />
                            <Vertex pos="0.25 -0.25 -1.5" />
                            <Vertex pos="0.25 -0.25 -2.5" />
                            <Vertex pos="-0.25 0.25 -1.5" />
                            <Vertex pos="-0.25 0.25 -2.5" />
                            <Vertex pos="-0.25 -0.25 -1.5" />
                            <Vertex pos="-0.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="-8.75 68.75 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -8.75 0 1 0 68.75 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 0.25 -1.25" />
                            <Vertex pos="-1.75 0.25 -2.75" />
                            <Vertex pos="-1.75 -0.25 -1.25" />
                            <Vertex pos="-1.75 -0.25 -2.75" />
                            <Vertex pos="-2.25 0.25 -1.25" />
                            <Vertex pos="-2.25 0.25 -2.75" />
                            <Vertex pos="-2.25 -0.25 -1.25" />
                            <Vertex pos="-2.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="452" owner="0" type="0" pos="-15.25 68.75 18.75" rot="1 0 0 0" scale="" transform="1 0 0 -15.25 0 1 0 68.75 0 0 1 18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 -1.25" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 -1.25" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 -1.25" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 -1.25" />
                            <Vertex pos="-0.25 -0.25 -2.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="454" owner="0" type="0" pos="-11.25 -54 4.5" rot="1 0 0 0" scale="" transform="1 0 0 -11.25 0 1 0 -54 0 0 1 4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 3 0" />
                            <Vertex pos="0.25 2 -0.5" />
                            <Vertex pos="0.25 -2 0" />
                            <Vertex pos="0.25 -2 -0.5" />
                            <Vertex pos="-0.25 3 0" />
                            <Vertex pos="-0.25 2 -0.5" />
                            <Vertex pos="-0.25 -2 0" />
                            <Vertex pos="-0.25 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -640 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.447214 -0.894427 -1.34164" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="455" owner="0" type="0" pos="26 65 20" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 65 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0 -6" />
                            <Vertex pos="3 0 -12" />
                            <Vertex pos="3 -2 -6" />
                            <Vertex pos="3 -2 -12" />
                            <Vertex pos="-1 0 -6" />
                            <Vertex pos="-1 0 -12" />
                            <Vertex pos="-1 -2 -6" />
                            <Vertex pos="-1 -2 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 1 704 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_tile05_C" texgens="1 0 0 6912 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="456" owner="0" type="0" pos="28.5 62.75 13.75" rot="1 0 0 0" scale="" transform="1 0 0 28.5 0 1 0 62.75 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 0.25" />
                            <Vertex pos="1 0.25 -0.25" />
                            <Vertex pos="1 -0.25 0.25" />
                            <Vertex pos="1 -0.25 -0.25" />
                            <Vertex pos="-1 0.25 0.25" />
                            <Vertex pos="-1 0.25 -0.25" />
                            <Vertex pos="-1 -0.25 0.25" />
                            <Vertex pos="-1 -0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="457" owner="0" type="0" pos="29.25 66 13.75" rot="1 0 0 0" scale="" transform="1 0 0 29.25 0 1 0 66 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 1 0.25" />
                            <Vertex pos="0.25 1 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="-0.25 1 0.25" />
                            <Vertex pos="-0.25 1 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="458" owner="0" type="0" pos="-9 61 25" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 61 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 19" />
                            <Vertex pos="2 2 3" />
                            <Vertex pos="2 -2 23" />
                            <Vertex pos="2 -2 3" />
                            <Vertex pos="-2 2 19" />
                            <Vertex pos="-2 2 3" />
                            <Vertex pos="-2 -2 23" />
                            <Vertex pos="-2 -2 3" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -14.8492" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="459" owner="0" type="0" pos="-11 65 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 65 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 6 0.25" />
                            <Vertex pos="4 6 -0.25" />
                            <Vertex pos="4 -2 0.25" />
                            <Vertex pos="4 -2 -0.25" />
                            <Vertex pos="0 6 0.25" />
                            <Vertex pos="0 6 -0.25" />
                            <Vertex pos="0 -2 0.25" />
                            <Vertex pos="0 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1408 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile05_C" texgens="1 0 0 -2560 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="460" owner="0" type="0" pos="-11.25 64 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -11.25 0 1 0 64 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 7 0.25" />
                            <Vertex pos="0.25 7 -0.25" />
                            <Vertex pos="0.25 -1 0.25" />
                            <Vertex pos="0.25 -1 -0.25" />
                            <Vertex pos="-0.25 7 0.25" />
                            <Vertex pos="-0.25 7 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 -1664 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="461" owner="0" type="0" pos="-9 71.125 23.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 71.125 0 0 1 23.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="0" plane="1 -0 0 -2.5" album="" material="bm_trim" texgens="0 1 0 32 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_trim" texgens="0 -1 0 96 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="" material="bm_trim" texgens="-1 0 0 640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="" material="bm_trim" texgens="1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_trim" texgens="1 0 0 -512 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_trim" texgens="-1 0 0 640 0 -1 0 96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="467" owner="0" type="0" pos="-28 57.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 57.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.25 -1.5" />
                            <Vertex pos="1 0.25 -2.5" />
                            <Vertex pos="1 -0.25 -1.5" />
                            <Vertex pos="1 -0.25 -2.5" />
                            <Vertex pos="-3 0.25 -1.5" />
                            <Vertex pos="-3 0.25 -2.5" />
                            <Vertex pos="-3 -0.25 -1.5" />
                            <Vertex pos="-3 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="-1 0 0 -512 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_grid_blank1" texgens="1 0 0 0 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -640 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="468" owner="0" type="0" pos="-28 57.25 12.25" rot="1 0 0 0" scale="" transform="1 0 0 -28 0 1 0 57.25 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.5 0.25 -1.75" />
                            <Vertex pos="1.5 0.25 -2.25" />
                            <Vertex pos="1.5 -0.25 -1.75" />
                            <Vertex pos="1.5 -0.25 -2.25" />
                            <Vertex pos="-3.5 0.25 -1.75" />
                            <Vertex pos="-3.5 0.25 -2.25" />
                            <Vertex pos="-3.5 -0.25 -1.75" />
                            <Vertex pos="-3.5 -0.25 -2.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 -256 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="469" owner="0" type="0" pos="-24.75 57.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.75 0 1 0 57.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.75 0.25 -1.5" />
                            <Vertex pos="-1.75 0.25 -2.5" />
                            <Vertex pos="-1.75 -0.25 -1.5" />
                            <Vertex pos="-1.75 -0.25 -2.5" />
                            <Vertex pos="-2.25 0.25 -1.5" />
                            <Vertex pos="-2.25 0.25 -2.5" />
                            <Vertex pos="-2.25 -0.25 -1.5" />
                            <Vertex pos="-2.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 1.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 576 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -448 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="470" owner="0" type="0" pos="-31.25 57.25 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -31.25 0 1 0 57.25 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 0.25 -1.5" />
                            <Vertex pos="0.25 0.25 -2.5" />
                            <Vertex pos="0.25 -0.25 -1.5" />
                            <Vertex pos="0.25 -0.25 -2.5" />
                            <Vertex pos="-0.25 0.25 -1.5" />
                            <Vertex pos="-0.25 0.25 -2.5" />
                            <Vertex pos="-0.25 -0.25 -1.5" />
                            <Vertex pos="-0.25 -0.25 -2.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 1.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="471" owner="0" type="0" pos="-13 59 34" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 59 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -4 30" />
                            <Vertex pos="6 -4 -2" />
                            <Vertex pos="6 -16 30" />
                            <Vertex pos="6 -16 -2" />
                            <Vertex pos="-6 -4 30" />
                            <Vertex pos="-6 -4 -2" />
                            <Vertex pos="-6 -16 30" />
                            <Vertex pos="-6 -16 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -30" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="472" owner="0" type="0" pos="-13 57 34" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 57 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -14 10" />
                            <Vertex pos="6 -14 -2" />
                            <Vertex pos="6 -16 10" />
                            <Vertex pos="6 -16 -2" />
                            <Vertex pos="-6 -14 10" />
                            <Vertex pos="-6 -14 -2" />
                            <Vertex pos="-6 -16 10" />
                            <Vertex pos="-6 -16 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2048 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="473" owner="0" type="0" pos="-13 57 46" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 57 0 0 1 46 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 -14 2" />
                            <Vertex pos="4 -14 -2" />
                            <Vertex pos="4 -16 2" />
                            <Vertex pos="4 -16 -2" />
                            <Vertex pos="-6 -14 2" />
                            <Vertex pos="-6 -14 -2" />
                            <Vertex pos="-6 -16 2" />
                            <Vertex pos="-6 -16 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2048 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="474" owner="0" type="0" pos="-13 57 50" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 57 0 0 1 50 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 -14 14" />
                            <Vertex pos="6 -14 -2" />
                            <Vertex pos="6 -16 14" />
                            <Vertex pos="6 -16 -2" />
                            <Vertex pos="-6 -14 14" />
                            <Vertex pos="-6 -14 -2" />
                            <Vertex pos="-6 -16 14" />
                            <Vertex pos="-6 -16 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2048 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -16" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 0 -1 1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="475" owner="0" type="0" pos="-6.625 58.75 26" rot="1 0 0 0" scale="" transform="1 0 0 -6.625 0 1 0 58.75 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 2" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 0 2" />
                            <Vertex pos="0 0 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="476" owner="0" type="0" pos="-6.625 43 26" rot="1 0 0 0" scale="" transform="1 0 0 -6.625 0 1 0 43 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 2" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 0 2" />
                            <Vertex pos="0 0 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="477" owner="0" type="0" pos="-6.625 51.5 24.25" rot="1 0 0 0" scale="" transform="1 0 0 -6.625 0 1 0 51.5 0 0 1 24.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 0" />
                            <Vertex pos="0 7.25 -0.25" />
                            <Vertex pos="0 -8.25 0" />
                            <Vertex pos="0 -8.25 -0.25" />
                            <Vertex pos="-0.25 7.25 0" />
                            <Vertex pos="-0.25 7.25 -0.25" />
                            <Vertex pos="-0.25 -8.25 0" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="478" owner="0" type="0" pos="-6.625 51.5 28" rot="1 0 0 0" scale="" transform="1 0 0 -6.625 0 1 0 51.5 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 0" />
                            <Vertex pos="0 7.25 -0.25" />
                            <Vertex pos="0 -8.25 0" />
                            <Vertex pos="0 -8.25 -0.25" />
                            <Vertex pos="-0.25 7.25 0" />
                            <Vertex pos="-0.25 7.25 -0.25" />
                            <Vertex pos="-0.25 -8.25 0" />
                            <Vertex pos="-0.25 -8.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -8.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="483" owner="0" type="0" pos="-19.125 58.75 26" rot="1 0 0 0" scale="" transform="1 0 0 -19.125 0 1 0 58.75 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 2" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 0 2" />
                            <Vertex pos="0 0 -2" />
                            <Vertex pos="-0.25 0.25 2" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 0 2" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="484" owner="0" type="0" pos="-19.125 43 26" rot="1 0 0 0" scale="" transform="1 0 0 -19.125 0 1 0 43 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -3.75 2" />
                            <Vertex pos="0 -3.75 -2" />
                            <Vertex pos="0 -4 2" />
                            <Vertex pos="0 -4 -2" />
                            <Vertex pos="-0.25 -3.75 2" />
                            <Vertex pos="-0.25 -3.75 -2" />
                            <Vertex pos="-0.25 -4 2" />
                            <Vertex pos="-0.25 -4 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.75" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="485" owner="0" type="0" pos="-19.125 51.5 24.25" rot="1 0 0 0" scale="" transform="1 0 0 -19.125 0 1 0 51.5 0 0 1 24.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 0" />
                            <Vertex pos="0 7.25 -0.25" />
                            <Vertex pos="0 -12.25 0" />
                            <Vertex pos="0 -12.25 -0.25" />
                            <Vertex pos="-0.25 7.25 0" />
                            <Vertex pos="-0.25 7.25 -0.25" />
                            <Vertex pos="-0.25 -12.25 0" />
                            <Vertex pos="-0.25 -12.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="486" owner="0" type="0" pos="-19.125 51.5 28" rot="1 0 0 0" scale="" transform="1 0 0 -19.125 0 1 0 51.5 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 0" />
                            <Vertex pos="0 7.25 -0.25" />
                            <Vertex pos="0 -12.25 0" />
                            <Vertex pos="0 -12.25 -0.25" />
                            <Vertex pos="-0.25 7.25 0" />
                            <Vertex pos="-0.25 7.25 -0.25" />
                            <Vertex pos="-0.25 -12.25 0" />
                            <Vertex pos="-0.25 -12.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="487" owner="0" type="0" pos="-15.125 38.75 6" rot="1 0 0 0" scale="" transform="1 0 0 -15.125 0 1 0 38.75 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 0.25 6" />
                            <Vertex pos="0 0.25 -2" />
                            <Vertex pos="0 0 6" />
                            <Vertex pos="0 0 -2" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="-0.25 0.25 -2" />
                            <Vertex pos="-0.25 0 6" />
                            <Vertex pos="-0.25 0 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -15040 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -15040 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="488" owner="0" type="0" pos="-15.125 23 6" rot="1 0 0 0" scale="" transform="1 0 0 -15.125 0 1 0 23 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 12.25 6" />
                            <Vertex pos="0 12.25 -2" />
                            <Vertex pos="0 12 6" />
                            <Vertex pos="0 12 -2" />
                            <Vertex pos="-0.25 12.25 6" />
                            <Vertex pos="-0.25 12.25 -2" />
                            <Vertex pos="-0.25 12 6" />
                            <Vertex pos="-0.25 12 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -11008 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 12" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -2" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -11008 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="489" owner="0" type="0" pos="-15.125 31.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -15.125 0 1 0 31.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 0" />
                            <Vertex pos="0 7.25 -0.25" />
                            <Vertex pos="0 3.75 0" />
                            <Vertex pos="0 3.75 -0.25" />
                            <Vertex pos="-0.25 7.25 0" />
                            <Vertex pos="-0.25 7.25 -0.25" />
                            <Vertex pos="-0.25 3.75 0" />
                            <Vertex pos="-0.25 3.75 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -6208 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="490" owner="0" type="0" pos="-15.125 31.5 8" rot="1 0 0 0" scale="" transform="1 0 0 -15.125 0 1 0 31.5 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 7.25 4" />
                            <Vertex pos="0 7.25 3.75" />
                            <Vertex pos="0 3.75 4" />
                            <Vertex pos="0 3.75 3.75" />
                            <Vertex pos="-0.25 7.25 4" />
                            <Vertex pos="-0.25 7.25 3.75" />
                            <Vertex pos="-0.25 3.75 4" />
                            <Vertex pos="-0.25 3.75 3.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.25" album="Blasted" material="bm_wood" texgens="0 -1 0 -13184 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="Blasted" material="bm_wood" texgens="1 0 0 -1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 3.75" album="Blasted" material="bm_wood" texgens="-1 0 0 1696 0 -1 0 -13184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="492" owner="0" type="0" pos="5 38 2.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 38 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 0.749999" />
                            <Vertex pos="2 1 0.25" />
                            <Vertex pos="2 -1 -0.25" />
                            <Vertex pos="2 -1 -0.749999" />
                            <Vertex pos="0 1 0.749999" />
                            <Vertex pos="0 1 0.25" />
                            <Vertex pos="0 -1 -0.25" />
                            <Vertex pos="0 -1 -0.749999" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_edge_white" texgens="0 1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -384 0 0 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447213 0.894427 -0.223606" album="Blasted" material="bm_stripe_caution2" texgens="1 1.5 0 96 0 -1 0 64 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.447213 -0.894427 -0.223606" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="493" owner="0" type="0" pos="26 65 20" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 65 0 0 1 20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 -6" />
                            <Vertex pos="3 2 -12" />
                            <Vertex pos="3 0 -6" />
                            <Vertex pos="3 0 -12" />
                            <Vertex pos="-1 2 -6" />
                            <Vertex pos="-1 2 -12" />
                            <Vertex pos="-1 0 -6" />
                            <Vertex pos="-1 0 -12" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_stripe_caution2" texgens="0 -1 -1 -1152 0 0 -1 -384 0 0.5 0.5" texRot="0" texScale="0.5 0.5" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 6" album="Blasted" material="bm_tile05_C" texgens="1 0 0 6912 0 -1 0 -16384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
