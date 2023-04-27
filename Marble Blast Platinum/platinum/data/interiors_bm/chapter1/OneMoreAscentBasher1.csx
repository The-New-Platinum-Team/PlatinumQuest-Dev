<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/22 18:35:17">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="5">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="5" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="6" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="7">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-14 -24 5.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-14 -36 5.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-14 -36 5.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="path_node" gametype="Torque" isPointEntity="1" origin="-14 -24 5.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-14 -24 5.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="4">
                    <Brush id="0" owner="0" type="0" pos="-14 -30 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -30 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
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
                        <Face id="2" plane="0 1 -0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -1152 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 -128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile01_D" texgens="1 0 0 256 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="1" type="999" pos="-14 -24 5.5" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -24 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_basher" texgens="0 1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_basher" texgens="0 -1 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_basher_side" texgens="-1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_basher_side" texgens="1 0 0 256 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="Blasted" material="bm_basher_top" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="Blasted" material="bm_basher_top" texgens="-1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-14 -26.875 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -26.875 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_trim" texgens="0 1 0 -1248 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_trim" texgens="0 -1 0 736 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 768 0 -1 0 992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -384 0 -1 0 240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-14 -33.125 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -33.125 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.125 0.25" />
                            <Vertex pos="1 0.125 -0.25" />
                            <Vertex pos="1 -0.125 0.25" />
                            <Vertex pos="1 -0.125 -0.25" />
                            <Vertex pos="-1 0.125 0.25" />
                            <Vertex pos="-1 0.125 -0.25" />
                            <Vertex pos="-1 -0.125 0.25" />
                            <Vertex pos="-1 -0.125 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="Blasted" material="bm_trim" texgens="0 1 0 -1184 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="Blasted" material="bm_trim" texgens="0 -1 0 672 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_trim" texgens="-1 0 0 -512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.125" album="Blasted" material="bm_trim" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 768 0 -1 0 928 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -384 0 -1 0 208 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
