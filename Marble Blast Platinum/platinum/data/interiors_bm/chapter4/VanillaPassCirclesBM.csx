<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2023/08/03 13:57:55">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="194">
                    <Brush id="2" owner="0" type="0" pos="16 -34.2611 33.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -34.2611 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.99998 0.261093 0.25" />
                            <Vertex pos="1.96579 -0.261097 0.25" />
                            <Vertex pos="-1.99998 0.261093 0.25" />
                            <Vertex pos="1.99998 0.261093 -0.25" />
                            <Vertex pos="1.96579 -0.261097 -0.25" />
                            <Vertex pos="-1.99998 0.261093 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 0.00463867 0 -1 0 1090.84 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 3617.42 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.997863 -0.0653342 0 -1.97865" album="Blasted" material="bm_edge_white" texgens="0.0654019 0.997859 0 32.2476 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.261093" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9997 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130547 -0.991442 -0 -0.00223368" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9997 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="15.9829 -34.5177 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.9829 0 1 0 -34.5177 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.98289 -0.00452805 0.25" />
                            <Vertex pos="1.88079 -0.517654 0.25" />
                            <Vertex pos="-1.98289 0.517658 0.25" />
                            <Vertex pos="1.98289 -0.00452805 -0.25" />
                            <Vertex pos="1.88079 -0.517654 -0.25" />
                            <Vertex pos="-1.98289 0.517658 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -4.3728 0 -1 0 1156.53 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -509.81 0 -1 0 3650.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.980773 -0.195151 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="0.1951 0.980783 0 34.4302 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130546 0.991442 -0 -0.254369" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 -0.130526 0 65.0715 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258829 -0.965923 -0 -0.0132113" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 -0.130526 0 65.0715 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="15.9318 -34.7653 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.9318 0 1 0 -34.7653 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.93184 -0.27 0.25" />
                            <Vertex pos="1.76368 -0.765305 0.25" />
                            <Vertex pos="-1.93184 0.765301 0.25" />
                            <Vertex pos="1.93184 -0.27 -0.25" />
                            <Vertex pos="1.76368 -0.765305 -0.25" />
                            <Vertex pos="-1.93184 0.765301 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -17.4543 0 -1 0 1219.91 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -503.269 0 -1 0 3681.96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946915 -0.321485 0 -1.91609" album="Blasted" material="bm_edge_white" texgens="0.321429 0.946934 0 38.6812 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.258826 0.965924 -0 -0.239211" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0511 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382656 -0.923891 -0 -0.0321756" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0511 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="15.8478 -35 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.8478 0 1 0 -35 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.8478 -0.53064 0.25" />
                            <Vertex pos="1.61636 -1.00002 0.25" />
                            <Vertex pos="-1.8478 1.00002 0.25" />
                            <Vertex pos="1.8478 -0.53064 -0.25" />
                            <Vertex pos="1.61636 -1.00002 -0.25" />
                            <Vertex pos="-1.8478 1.00002 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -38.9583 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -492.517 0 -1 0 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896897 -0.442239 0 -1.89196" album="Blasted" material="bm_edge_white" texgens="0.442291 0.896872 0 44.4902 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.38266 0.923889 -0 -0.216828" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8728 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500001 -0.866025 -0 -0.0578601" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8728 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="15.7321 -35.2175 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.7321 0 1 0 -35.2175 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.73202 -0.782497 0.25" />
                            <Vertex pos="1.44137 -1.21749 0.25" />
                            <Vertex pos="-1.73202 1.21749 0.25" />
                            <Vertex pos="1.73202 -0.782497 -0.25" />
                            <Vertex pos="1.44137 -1.21749 -0.25" />
                            <Vertex pos="-1.73202 1.21749 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -68.5774 0 -1 0 1335.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -477.708 0 -1 0 3739.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831472 -0.555566 0 -1.87486" album="Blasted" material="bm_edge_white" texgens="0.555578 0.831465 0 51.7588 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.500004 0.866023 -0 -0.188357" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4806 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608754 -0.793359 -0 -0.0884672" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4806 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="15.5867 -35.4142 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.5867 0 1 0 -35.4142 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.58667 -1.02077 0.25" />
                            <Vertex pos="1.24174 -1.41421 0.25" />
                            <Vertex pos="-1.58667 1.4142 0.25" />
                            <Vertex pos="1.58667 -1.02077 -0.25" />
                            <Vertex pos="1.24174 -1.41421 -0.25" />
                            <Vertex pos="-1.58667 1.4142 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -105.8 0 -1 0 1386.03 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -459.096 0 -1 0 3765.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751942 -0.65923 0 -1.86601" album="Blasted" material="bm_edge_white" texgens="0.659331 0.751853 0 59.8181 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.608758 0.793356 -0 -0.156065" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793354 -0.608761 0 67.8362 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707107 -0.707107 -0 -0.121955" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793354 -0.608761 0 67.8362 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="15.4142 -35.5867 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.4142 0 1 0 -35.5867 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.4142 -1.24171 0.25" />
                            <Vertex pos="1.02083 -1.58672 0.25" />
                            <Vertex pos="-1.4142 1.58671 0.25" />
                            <Vertex pos="1.4142 -1.24171 -0.25" />
                            <Vertex pos="1.02083 -1.58672 -0.25" />
                            <Vertex pos="-1.4142 1.58671 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -149.96 0 -1 0 1430.19 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -437.016 0 -1 0 3787.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659382 -0.751808 0 -1.86603" album="Blasted" material="bm_edge_white" texgens="0.751844 0.659341 0 68.1643 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707109 0.707104 -0 -0.121976" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.8997 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793357 -0.608757 -0 -0.156044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.8997 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="15.2175 -35.732 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.2175 0 1 0 -35.732 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.21753 -1.44141 0.25" />
                            <Vertex pos="0.782467 -1.73203 0.25" />
                            <Vertex pos="-1.21753 1.73203 0.25" />
                            <Vertex pos="1.21753 -1.44141 -0.25" />
                            <Vertex pos="0.782467 -1.73203 -0.25" />
                            <Vertex pos="-1.21753 1.73203 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -200.315 0 -1 0 1467.39 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -411.839 0 -1 0 3805.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555465 -0.83154 0 -1.87489" album="Blasted" material="bm_edge_white" texgens="0.831468 0.555573 0 76.2532 0 0 -1 64 0 0.130811 0.125" texRot="0" texScale="0.130811 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.793354 0.608761 -0 -0.088459" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 -0.793352 0 67.6918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866023 -0.500004 -0 -0.188387" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 -0.793352 0 67.6918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="15 -35.8478 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -35.8478 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 -1.61625 0.25" />
                            <Vertex pos="0.530719 -1.84781 0.25" />
                            <Vertex pos="-1 1.84782 0.25" />
                            <Vertex pos="1 -1.61625 -0.25" />
                            <Vertex pos="0.530719 -1.84781 -0.25" />
                            <Vertex pos="-1 1.84782 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -255.995 0 -1 0 1497.03 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -383.999 0 -1 0 3820.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442498 -0.89677 0 -1.8919" album="Blasted" material="bm_edge_white" texgens="0.896879 0.442276 0 83.4695 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866023 0.500003 -0 -0.0578929" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2041 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923885 -0.38267 -0 -0.216779" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2041 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="14.7654 -35.9319 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.7654 0 1 0 -35.9319 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.765359 -1.76375 0.25" />
                            <Vertex pos="0.26989 -1.93187 0.25" />
                            <Vertex pos="-0.765359 1.93187 0.25" />
                            <Vertex pos="0.765359 -1.76375 -0.25" />
                            <Vertex pos="0.26989 -1.93187 -0.25" />
                            <Vertex pos="-0.765359 1.93187 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -316.053 0 -1 0 1518.56 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -353.97 0 -1 0 3831.28 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321321 -0.94697 0 -1.91614" album="Blasted" material="bm_edge_white" texgens="0.946928 0.321446 0 89.3955 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.923885 0.382671 -0 -0.0321674" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4904 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965928 -0.25881 -0 -0.239294" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4904 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="14.5176 -35.983 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.5176 0 1 0 -35.983 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.517624 -1.88078 0.25" />
                            <Vertex pos="0.00446796 -1.98296 0.25" />
                            <Vertex pos="-0.517624 1.98296 0.25" />
                            <Vertex pos="0.517624 -1.88078 -0.25" />
                            <Vertex pos="0.00446796 -1.98296 -0.25" />
                            <Vertex pos="-0.517624 1.98296 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -379.49 0 -1 0 1531.65 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -322.251 0 -1 0 3837.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195287 -0.980746 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="0.980787 0.19508 0 93.5581 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965928 0.25881 -0 -0.0132226" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5776 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991446 -0.130519 -0 -0.254383" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5776 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="14.261 -36 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.261 0 1 0 -36 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.261046 -1.96594 0.25" />
                            <Vertex pos="-0.261047 -2 0.25" />
                            <Vertex pos="-0.261047 2 0.25" />
                            <Vertex pos="0.261046 -1.96594 -0.25" />
                            <Vertex pos="-0.261047 -2 -0.25" />
                            <Vertex pos="-0.261047 2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -445.179 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -289.407 0 -1 0 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.065099 -0.997879 0 -1.97876" album="Blasted" material="bm_edge_white" texgens="0.997859 0.065402 0 95.7112 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991446 0.130518 -0 -0.00222224" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5391 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.261047" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5391 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="13.7389 -36 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.7389 0 1 0 -36 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.26106 -1.99998 0.25" />
                            <Vertex pos="-0.261061 -1.96593 0.25" />
                            <Vertex pos="0.26106 1.99999 0.25" />
                            <Vertex pos="0.26106 -1.99998 -0.25" />
                            <Vertex pos="-0.261061 -1.96593 -0.25" />
                            <Vertex pos="0.26106 1.99999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -578.837 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -222.578 0 -1 0 3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0650765 -0.99788 -0 -1.97875" album="Blasted" material="bm_edge_white" texgens="0.997859 -0.0654019 0 32.3037 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.26106" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.0005 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991445 0.130526 0 -0.00222334" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.0005 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="13.4824 -35.983 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.4824 0 1 0 -35.983 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.00448513 -1.98296 0.25" />
                            <Vertex pos="-0.517636 -1.88078 0.25" />
                            <Vertex pos="0.517636 1.98296 0.25" />
                            <Vertex pos="-0.00448513 -1.98296 -0.25" />
                            <Vertex pos="-0.517636 -1.88078 -0.25" />
                            <Vertex pos="0.517636 1.98296 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -644.501 0 -1 0 1531.65 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -189.746 0 -1 0 3837.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.195289 -0.980746 -0 -1.94566" album="Blasted" material="bm_edge_white" texgens="0.980784 -0.195098 0 34.4326 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991445 -0.130526 0 -0.25438" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.13053 -0.991444 0 65.0778 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965927 0.258816 0 -0.0132229" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.13053 -0.991444 0 65.0778 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="13.2346 -35.9318 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.2346 0 1 0 -35.9318 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.269912 -1.9319 0.25" />
                            <Vertex pos="-0.765386 -1.76378 0.25" />
                            <Vertex pos="0.765386 1.9319 0.25" />
                            <Vertex pos="-0.269912 -1.9319 -0.25" />
                            <Vertex pos="-0.765386 -1.76378 -0.25" />
                            <Vertex pos="0.765386 1.9319 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -707.938 0 -1 0 1518.54 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -158.028 0 -1 0 3831.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321318 -0.946971 -0 -1.91618" album="Blasted" material="bm_edge_white" texgens="0.946928 -0.321446 0 38.6465 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965926 -0.258818 0 -0.239296" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0505 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923882 0.382677 0 -0.0321678" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0505 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="13 -35.8478 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -35.8478 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.53072 -1.84782 0.25" />
                            <Vertex pos="-1 -1.61626 0.25" />
                            <Vertex pos="1 1.84782 0.25" />
                            <Vertex pos="-0.53072 -1.84782 -0.25" />
                            <Vertex pos="-1 -1.61626 -0.25" />
                            <Vertex pos="1 1.84782 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -767.995 0 -1 0 1497.03 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -127.999 0 -1 0 3820.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442499 -0.896769 -0 -1.89191" album="Blasted" material="bm_edge_white" texgens="0.896872 -0.442291 0 44.6211 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.923885 -0.38267 0 -0.21678" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8758 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866024 0.500002 0 -0.0578902" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8758 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="12.7825 -35.732 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.7825 0 1 0 -35.732 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.782535 -1.73205 0.25" />
                            <Vertex pos="-1.21754 -1.44142 0.25" />
                            <Vertex pos="1.21754 1.73205 0.25" />
                            <Vertex pos="-0.782535 -1.73205 -0.25" />
                            <Vertex pos="-1.21754 -1.44142 -0.25" />
                            <Vertex pos="1.21754 1.73205 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -823.675 0 -1 0 1467.39 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -100.159 0 -1 0 3805.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.555529 -0.831497 -0 -1.87492" album="Blasted" material="bm_edge_white" texgens="0.831464 -0.555578 0 51.7852 0 0 -1 64 0 0.130796 0.125" texRot="0" texScale="0.130796 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866017 -0.500014 0 -0.188361" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.4807 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793354 0.60876 0 -0.0884619" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.4807 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="12.5858 -35.5867 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.5858 0 1 0 -35.5867 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.02082 -1.58671 0.25" />
                            <Vertex pos="-1.4142 -1.24171 0.25" />
                            <Vertex pos="1.4142 1.58671 0.25" />
                            <Vertex pos="-1.02082 -1.58671 -0.25" />
                            <Vertex pos="-1.4142 -1.24171 -0.25" />
                            <Vertex pos="1.4142 1.58671 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -874.031 0 -1 0 1430.19 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -74.9812 0 -1 0 3787.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.659362 -0.751826 -0 -1.86602" album="Blasted" material="bm_edge_white" texgens="0.751844 -0.659341 0 59.9136 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.793357 -0.608757 0 -0.156045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8338 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707109 0.707104 0 -0.121975" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8338 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="12.4133 -35.4142 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.4133 0 1 0 -35.4142 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.24169 -1.41422 0.25" />
                            <Vertex pos="-1.58669 -1.02078 0.25" />
                            <Vertex pos="1.58669 1.41422 0.25" />
                            <Vertex pos="-1.24169 -1.41422 -0.25" />
                            <Vertex pos="-1.58669 -1.02078 -0.25" />
                            <Vertex pos="1.58669 1.41422 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -918.191 0 -1 0 1386.03 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -52.9011 0 -1 0 3765.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751876 -0.659305 -0 -1.866" album="Blasted" material="bm_edge_white" texgens="0.659351 -0.751835 0 68.1338 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707114 -0.707099 0 -0.121977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.9041 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608758 0.793356 0 -0.156069" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.9041 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="12.268 -35.2175 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.268 0 1 0 -35.2175 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.44137 -1.2175 0.25" />
                            <Vertex pos="-1.73203 -0.782497 0.25" />
                            <Vertex pos="1.73203 1.2175 0.25" />
                            <Vertex pos="-1.44137 -1.2175 -0.25" />
                            <Vertex pos="-1.73203 -0.782497 -0.25" />
                            <Vertex pos="1.73203 1.2175 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -955.387 0 -1 0 1335.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -34.3027 0 -1 0 3739.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.831469 -0.555571 -0 -1.87486" album="Blasted" material="bm_edge_white" texgens="0.555569 -0.83147 0 76.251 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.608756 -0.793358 0 -0.0884705" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6886 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500004 0.866023 0 -0.188361" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6886 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="12.1523 -35 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.1523 0 1 0 -35 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.61642 -1.00002 0.25" />
                            <Vertex pos="-1.84783 -0.530632 0.25" />
                            <Vertex pos="1.84783 1.00002 0.25" />
                            <Vertex pos="-1.61642 -1.00002 -0.25" />
                            <Vertex pos="-1.84783 -0.530632 -0.25" />
                            <Vertex pos="1.84783 1.00002 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -985.006 0 -1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -19.4932 0 -1 0 3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.896923 -0.442186 -0 -1.892" album="Blasted" material="bm_edge_white" texgens="0.442299 -0.896868 0 83.5498 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.499991 -0.86603 0 -0.0578516" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.2037 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382653 0.923892 0 -0.216832" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.2037 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="12.0682 -34.7653 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.0682 0 1 0 -34.7653 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.76365 -0.765308 0.25" />
                            <Vertex pos="-1.93184 -0.27 0.25" />
                            <Vertex pos="1.93184 0.765305 0.25" />
                            <Vertex pos="-1.76365 -0.765308 -0.25" />
                            <Vertex pos="-1.93184 -0.27 -0.25" />
                            <Vertex pos="1.93184 0.765305 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1006.54 0 -1 0 1219.91 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -8.72827 0 -1 0 3681.96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946898 -0.321535 -0 -1.91607" album="Blasted" material="bm_edge_white" texgens="0.321446 -0.946928 0 89.3271 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.38266 -0.923889 0 -0.0321813" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.4857 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258827 0.965924 0 -0.239213" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.4857 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="12.0171 -34.5177 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.0171 0 1 0 -34.5177 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.8808 -0.517658 0.25" />
                            <Vertex pos="-1.98289 -0.00452805 0.25" />
                            <Vertex pos="1.98289 0.517658 0.25" />
                            <Vertex pos="-1.8808 -0.517658 -0.25" />
                            <Vertex pos="-1.98289 -0.00452805 -0.25" />
                            <Vertex pos="1.98289 0.517658 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1019.62 0 -1 0 1156.53 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2.1875 0 -1 0 3650.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980777 -0.195131 -0 -1.94566" album="Blasted" material="bm_edge_white" texgens="0.195097 -0.980784 0 93.5371 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.258829 -0.965923 0 -0.013212" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5767 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130546 0.991442 0 -0.254369" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5767 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="12 -34.2611 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -34.2611 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.96577 -0.261093 0.25" />
                            <Vertex pos="-1.99999 0.261093 0.25" />
                            <Vertex pos="1.99999 0.261093 0.25" />
                            <Vertex pos="-1.96577 -0.261093 -0.25" />
                            <Vertex pos="-1.99999 0.261093 -0.25" />
                            <Vertex pos="1.99999 0.261093 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1024 0 -1 0 1090.84 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0.0012207 0 -1 0 3617.42 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.99786 -0.0653919 -0 -1.97864" album="Blasted" material="bm_edge_white" texgens="0.0654018 -0.997859 0 95.7314 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130547 -0.991442 0 -0.00223365" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5425 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 1 0 -0.261093" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5425 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="12 -33.7389 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 -33.7389 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-2.00001 -0.261093 0.25" />
                            <Vertex pos="-1.96579 0.261093 0.25" />
                            <Vertex pos="2.00001 -0.261093 0.25" />
                            <Vertex pos="-2.00001 -0.261093 -0.25" />
                            <Vertex pos="-1.96579 0.261093 -0.25" />
                            <Vertex pos="2.00001 -0.261093 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1024 0 -1 0 957.156 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0.0012207 0 -1 0 3550.58 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.99786 0.0653919 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="-0.0654019 -0.997859 0 32.2202 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.261093" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9968 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130545 0.991442 0 -0.00223362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9968 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="12.0171 -33.4823 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.0171 0 1 0 -33.4823 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.98289 0.00453186 0.25" />
                            <Vertex pos="-1.88083 0.517662 0.25" />
                            <Vertex pos="1.98289 -0.517662 0.25" />
                            <Vertex pos="-1.98289 0.00453186 -0.25" />
                            <Vertex pos="-1.88083 0.517662 -0.25" />
                            <Vertex pos="1.98289 -0.517662 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1019.62 0 -1 0 891.466 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2.1875 0 -1 0 3517.73 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980788 0.195076 0 -1.94568" album="Blasted" material="bm_edge_white" texgens="-0.195078 -0.980788 0 34.4336 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130548 -0.991442 0 -0.254369" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 0.130524 0 65.0721 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258829 0.965923 0 -0.0132081" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 0.130524 0 65.0721 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="12.0682 -33.2347 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.0682 0 1 0 -33.2347 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.93189 0.270004 0.25" />
                            <Vertex pos="-1.76367 0.765316 0.25" />
                            <Vertex pos="1.93189 -0.765312 0.25" />
                            <Vertex pos="-1.93189 0.270004 -0.25" />
                            <Vertex pos="-1.76367 0.765316 -0.25" />
                            <Vertex pos="1.93189 -0.765312 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -1006.54 0 -1 0 828.081 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -8.72827 0 -1 0 3486.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946881 0.321584 0 -1.9161" album="Blasted" material="bm_edge_white" texgens="-0.321446 -0.946928 0 38.6348 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258824 -0.965925 0 -0.239215" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.382657 0.92389 0 -0.0321871" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.0518 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="12.1522 -33 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.1522 0 1 0 -33 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.84775 0.530621 0.25" />
                            <Vertex pos="-1.61631 1 0.25" />
                            <Vertex pos="1.84775 -1 0.25" />
                            <Vertex pos="-1.84775 0.530621 -0.25" />
                            <Vertex pos="-1.61631 1 -0.25" />
                            <Vertex pos="1.84775 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -985.032 0 -1 0 767.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -19.4802 0 -1 0 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.896897 0.442239 0 -1.8919" album="Blasted" material="bm_edge_white" texgens="-0.442299 -0.896868 0 44.5015 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.382661 -0.923889 0 -0.216827" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8745 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.500005 0.866023 0 -0.0578605" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8745 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="12.268 -32.7825 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.268 0 1 0 -32.7825 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.73207 0.782509 0.25" />
                            <Vertex pos="-1.44138 1.21751 0.25" />
                            <Vertex pos="1.73207 -1.21751 0.25" />
                            <Vertex pos="-1.73207 0.782509 -0.25" />
                            <Vertex pos="-1.44138 1.21751 -0.25" />
                            <Vertex pos="1.73207 -1.21751 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -955.387 0 -1 0 712.318 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -34.3027 0 -1 0 3428.16 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.831442 0.555612 0 -1.87489" album="Blasted" material="bm_edge_white" texgens="-0.555556 -0.83148 0 51.7788 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499999 -0.866026 0 -0.188361" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4797 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608753 0.79336 0 -0.0884792" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4797 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="12.4133 -32.5858 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.4133 0 1 0 -32.5858 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.58668 1.02079 0.25" />
                            <Vertex pos="-1.24175 1.4142 0.25" />
                            <Vertex pos="1.58668 -1.4142 0.25" />
                            <Vertex pos="-1.58668 1.02079 -0.25" />
                            <Vertex pos="-1.24175 1.4142 -0.25" />
                            <Vertex pos="1.58668 -1.4142 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -918.191 0 -1 0 661.962 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -52.9011 0 -1 0 3402.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751917 0.659258 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="-0.659351 -0.751835 0 59.8181 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608759 -0.793355 0 -0.156057" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.793355 0.60876 0 67.8273 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707103 0.707111 0 -0.12195" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.793355 0.60876 0 67.8273 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="12.5858 -32.4133 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.5858 0 1 0 -32.4133 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.41422 1.2417 0.25" />
                            <Vertex pos="-1.02084 1.5867 0.25" />
                            <Vertex pos="1.41422 -1.5867 0.25" />
                            <Vertex pos="-1.41422 1.2417 -0.25" />
                            <Vertex pos="-1.02084 1.5867 -0.25" />
                            <Vertex pos="1.41422 -1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -874.031 0 -1 0 617.802 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -74.9812 0 -1 0 3380.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.659362 0.751826 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="-0.751835 -0.659351 0 68.1975 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707102 -0.707112 0 -0.121977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9069 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.79335 0.608765 0 -0.156044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9069 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="12.7825 -32.2679 33.75" rot="1 0 0 0" scale="" transform="1 0 0 12.7825 0 1 0 -32.2679 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.21753 1.44135 0.25" />
                            <Vertex pos="-0.782466 1.73207 0.25" />
                            <Vertex pos="1.21753 -1.73207 0.25" />
                            <Vertex pos="-1.21753 1.44135 -0.25" />
                            <Vertex pos="-0.782466 1.73207 -0.25" />
                            <Vertex pos="1.21753 -1.73207 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -823.675 0 -1 0 580.58 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -100.159 0 -1 0 3362.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.555596 0.831452 0 -1.87487" album="Blasted" material="bm_edge_white" texgens="-0.831471 -0.555569 0 76.259 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.793352 -0.608763 0 -0.0884897" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6875 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866028 0.499995 0 -0.188389" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6875 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="13 -32.1522 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -32.1522 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 1.61635 0.25" />
                            <Vertex pos="-0.530722 1.84779 0.25" />
                            <Vertex pos="1 -1.84779 0.25" />
                            <Vertex pos="-1 1.61635 -0.25" />
                            <Vertex pos="-0.530722 1.84779 -0.25" />
                            <Vertex pos="1 -1.84779 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -767.995 0 -1 0 550.96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -127.999 0 -1 0 3347.48 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442316 0.896859 0 -1.89195" album="Blasted" material="bm_edge_white" texgens="-0.896872 -0.442291 0 83.4791 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866028 -0.499996 0 -0.0578595" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.2118 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923883 0.382675 0 -0.216779" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.2118 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="13.2346 -32.0682 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.2346 0 1 0 -32.0682 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.765362 1.76367 0.25" />
                            <Vertex pos="-0.269921 1.93183 0.25" />
                            <Vertex pos="0.765362 -1.93184 0.25" />
                            <Vertex pos="-0.765362 1.76367 -0.25" />
                            <Vertex pos="-0.269921 1.93183 -0.25" />
                            <Vertex pos="0.765362 -1.93184 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -707.938 0 -1 0 529.457 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -158.028 0 -1 0 3336.73 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321406 0.946942 0 -1.91608" album="Blasted" material="bm_edge_white" texgens="-0.946934 -0.321429 0 89.3775 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.92388 -0.382682 0 -0.0321777" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382683 0.92388 0 66.4822 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 0.258823 0 -0.239278" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382683 0.92388 0 66.4822 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="13.4824 -32.0171 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.4824 0 1 0 -32.0171 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.517643 1.88079 0.25" />
                            <Vertex pos="-0.00445461 1.98291 0.25" />
                            <Vertex pos="0.517643 -1.98291 0.25" />
                            <Vertex pos="-0.517643 1.88079 -0.25" />
                            <Vertex pos="-0.00445461 1.98291 -0.25" />
                            <Vertex pos="0.517643 -1.98291 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -644.501 0 -1 0 516.375 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -189.746 0 -1 0 3330.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.195165 0.98077 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="-0.980784 -0.195099 0 93.5709 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965925 -0.258822 0 -0.0132154" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.58 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 0.130523 0 -0.254399" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.58 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="13.739 -32 33.75" rot="1 0 0 0" scale="" transform="1 0 0 13.739 0 1 0 -32 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.261045 1.96577 0.25" />
                            <Vertex pos="0.261046 1.99999 0.25" />
                            <Vertex pos="0.261046 -1.99999 0.25" />
                            <Vertex pos="-0.261045 1.96577 -0.25" />
                            <Vertex pos="0.261046 1.99999 -0.25" />
                            <Vertex pos="0.261046 -1.99999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -578.811 0 -1 0 511.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -222.591 0 -1 0 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0654038 0.997859 0 -1.97863" album="Blasted" material="bm_edge_white" texgens="-0.997859 -0.0654019 0 95.7207 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991445 -0.130523 0 -0.00223276" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.130525 0.991445 0 64.5458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="1 -0 0 -0.261046" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.130525 0.991445 0 64.5458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="14.2611 -32 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.2611 0 1 0 -32 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.261064 2.00001 0.25" />
                            <Vertex pos="0.261064 1.96579 0.25" />
                            <Vertex pos="-0.261064 -2.00001 0.25" />
                            <Vertex pos="-0.261064 2.00001 -0.25" />
                            <Vertex pos="0.261064 1.96579 -0.25" />
                            <Vertex pos="-0.261064 -2.00001 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -445.154 0 -1 0 511.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -289.419 0 -1 0 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0653991 0.997859 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="-0.997859 0.065402 0 32.2776 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -0.261064" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9998 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991444 -0.130531 0 -0.00223339" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9998 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="14.5176 -32.0171 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.5176 0 1 0 -32.0171 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.00445175 1.98291 0.25" />
                            <Vertex pos="0.517642 1.88082 0.25" />
                            <Vertex pos="-0.517642 -1.98291 0.25" />
                            <Vertex pos="0.00445175 1.98291 -0.25" />
                            <Vertex pos="0.517642 1.88082 -0.25" />
                            <Vertex pos="-0.517642 -1.98291 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -379.49 0 -1 0 516.375 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -322.251 0 -1 0 3330.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195109 0.980782 0 -1.94567" album="Blasted" material="bm_edge_white" texgens="-0.980784 0.195098 0 34.3623 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991445 0.130522 0 -0.2544" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0757 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965926 -0.258819 0 -0.0132114" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0757 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="14.7654 -32.0681 33.75" rot="1 0 0 0" scale="" transform="1 0 0 14.7654 0 1 0 -32.0681 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.269905 1.93185 0.25" />
                            <Vertex pos="0.76537 1.76366 0.25" />
                            <Vertex pos="-0.76537 -1.93185 0.25" />
                            <Vertex pos="0.269905 1.93185 -0.25" />
                            <Vertex pos="0.76537 1.76366 -0.25" />
                            <Vertex pos="-0.76537 -1.93185 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -316.053 0 -1 0 529.431 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -353.97 0 -1 0 3336.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321443 0.946929 0 -1.91608" album="Blasted" material="bm_edge_white" texgens="-0.946928 0.321446 0 38.6348 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965926 0.258819 0 -0.239291" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923879 -0.382686 0 -0.032182" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="15 -32.1523 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -32.1523 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.530752 1.84774 0.25" />
                            <Vertex pos="1 1.61633 0.25" />
                            <Vertex pos="-1 -1.84774 0.25" />
                            <Vertex pos="0.530752 1.84774 -0.25" />
                            <Vertex pos="1 1.61633 -0.25" />
                            <Vertex pos="-1 -1.84774 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -255.995 0 -1 0 550.987 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -383.999 0 -1 0 3347.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442293 0.896871 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="-0.896879 0.442276 0 44.5024 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.923877 0.382691 0 -0.216764" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866023 -0.500003 0 -0.0578529" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="15.2175 -32.2679 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.2175 0 1 0 -32.2679 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.782475 1.73208 0.25" />
                            <Vertex pos="1.21754 1.44139 0.25" />
                            <Vertex pos="-1.21754 -1.73208 0.25" />
                            <Vertex pos="0.782475 1.73208 -0.25" />
                            <Vertex pos="1.21754 1.44139 -0.25" />
                            <Vertex pos="-1.21754 -1.73208 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -200.315 0 -1 0 580.58 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -411.839 0 -1 0 3362.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555555 0.831479 0 -1.8749" album="Blasted" material="bm_edge_white" texgens="-0.831465 0.555578 0 51.7061 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866027 0.499996 0 -0.188389" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4796 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.793354 -0.60876 0 -0.0884803" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4796 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="15.4142 -32.4133 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.4142 0 1 0 -32.4133 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.02085 1.5867 0.25" />
                            <Vertex pos="1.41422 1.2417 0.25" />
                            <Vertex pos="-1.41422 -1.58671 0.25" />
                            <Vertex pos="1.02085 1.5867 -0.25" />
                            <Vertex pos="1.41422 1.2417 -0.25" />
                            <Vertex pos="-1.41422 -1.58671 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -149.96 0 -1 0 617.802 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -437.016 0 -1 0 3380.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659371 0.751817 0 -1.86603" album="Blasted" material="bm_edge_white" texgens="-0.751835 0.659351 0 59.8462 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.79335 0.608766 0 -0.156037" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8323 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707103 -0.70711 0 -0.12198" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8323 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="15.5867 -32.5858 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.5867 0 1 0 -32.5858 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.24172 1.41422 0.25" />
                            <Vertex pos="1.58669 1.02081 0.25" />
                            <Vertex pos="-1.58668 -1.41421 0.25" />
                            <Vertex pos="1.24172 1.41422 -0.25" />
                            <Vertex pos="1.58669 1.02081 -0.25" />
                            <Vertex pos="-1.58668 -1.41421 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -105.8 0 -1 0 661.962 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -459.096 0 -1 0 3402.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751879 0.659301 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="-0.659351 0.751835 0 68.1602 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707111 0.707103 0 -0.121966" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.9033 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608763 -0.793352 0 -0.156055" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.9033 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="15.7321 -32.7825 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.7321 0 1 0 -32.7825 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.44135 1.21751 0.25" />
                            <Vertex pos="1.73208 0.782505 0.25" />
                            <Vertex pos="-1.73208 -1.21751 0.25" />
                            <Vertex pos="1.44135 1.21751 -0.25" />
                            <Vertex pos="1.73208 0.782505 -0.25" />
                            <Vertex pos="-1.73208 -1.21751 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -68.5774 0 -1 0 712.318 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -477.708 0 -1 0 3428.16 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831409 0.555661 0 -1.87487" album="Blasted" material="bm_edge_white" texgens="-0.555569 0.831471 0 76.29 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608755 0.793358 0 -0.0884918" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.6893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.499996 -0.866027 0 -0.188363" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.6893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="15.8478 -33 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.8478 0 1 0 -33 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.61632 0.999981 0.25" />
                            <Vertex pos="1.84775 0.530617 0.25" />
                            <Vertex pos="-1.84775 -0.999981 0.25" />
                            <Vertex pos="1.61632 0.999981 -0.25" />
                            <Vertex pos="1.84775 0.530617 -0.25" />
                            <Vertex pos="-1.84775 -0.999981 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -38.9583 0 -1 0 767.998 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -492.517 0 -1 0 3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896899 0.442235 0 -1.8919" album="Blasted" material="bm_edge_white" texgens="-0.442276 0.896879 0 83.5254 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499996 0.866028 0 -0.057857" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2085 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.382656 -0.923891 0 -0.216821" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2085 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="15.9318 -33.2347 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.9318 0 1 0 -33.2347 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.7637 0.76532 0.25" />
                            <Vertex pos="1.93189 0.270004 0.25" />
                            <Vertex pos="-1.93189 -0.765316 0.25" />
                            <Vertex pos="1.7637 0.76532 -0.25" />
                            <Vertex pos="1.93189 0.270004 -0.25" />
                            <Vertex pos="-1.93189 -0.765316 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -17.4543 0 -1 0 828.081 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -503.269 0 -1 0 3486.04 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946899 0.32153 0 -1.91612" album="Blasted" material="bm_edge_white" texgens="-0.321446 0.946928 0 89.3242 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.382656 0.923891 0 -0.0321813" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4857 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258824 -0.965924 0 -0.239217" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4857 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="15.9829 -33.4823 33.75" rot="1 0 0 0" scale="" transform="1 0 0 15.9829 0 1 0 -33.4823 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.88081 0.517654 0.25" />
                            <Vertex pos="1.98287 0.00453186 0.25" />
                            <Vertex pos="-1.98287 -0.517658 0.25" />
                            <Vertex pos="1.88081 0.517654 -0.25" />
                            <Vertex pos="1.98287 0.00453186 -0.25" />
                            <Vertex pos="-1.98287 -0.517658 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 -4.3728 0 -1 0 891.466 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -509.81 0 -1 0 3517.73 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.980788 0.195079 0 -1.94566" album="Blasted" material="bm_edge_white" texgens="-0.195079 0.980788 0 93.5342 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258829 0.965923 0 -0.0132061" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.577 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130548 -0.991442 0 -0.254367" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.577 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="16 -33.7389 33.75" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -33.7389 0 0 1 33.75 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.96579 0.261093 0.25" />
                            <Vertex pos="2.00001 -0.261093 0.25" />
                            <Vertex pos="-2.00001 -0.261093 0.25" />
                            <Vertex pos="1.96579 0.261093 -0.25" />
                            <Vertex pos="2.00001 -0.261093 -0.25" />
                            <Vertex pos="-2.00001 -0.261093 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_tile07_D" texgens="1 0 0 0.00463867 0 -1 0 957.156 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 3550.58 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.99786 0.0653919 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="-0.0654041 0.997859 0 95.7246 0 0 -1 64 0 0.130802 0.125" texRot="0" texScale="0.130802 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130545 0.991442 0 -0.00223365" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 0.130522 0 64.5422 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.261093" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 0.130522 0 64.5422 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="20 -26.261 33.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -26.261 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2.00002 0.261063 0.25" />
                            <Vertex pos="1.9658 -0.261063 0.25" />
                            <Vertex pos="-2.00002 0.261063 0.25" />
                            <Vertex pos="2.00002 0.261063 -0.25" />
                            <Vertex pos="1.9658 -0.261063 -0.25" />
                            <Vertex pos="-2.00002 0.261063 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5120 0 -1 0 6722.82 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 2593.41 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.997859 -0.0653994 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="0.0654019 0.997859 0 32.2939 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9993 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.13053 -0.991444 -0 -0.00223336" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9993 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="19.9829 -26.5176 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9829 0 1 0 -26.5176 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.98289 -0.00444794 0.25" />
                            <Vertex pos="1.8808 -0.517639 0.25" />
                            <Vertex pos="-1.98289 0.517641 0.25" />
                            <Vertex pos="1.98289 -0.00444794 -0.25" />
                            <Vertex pos="1.8808 -0.517639 -0.25" />
                            <Vertex pos="-1.98289 0.517641 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5115.62 0 -1 0 6788.51 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1021.81 0 -1 0 2626.25 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.980782 -0.195109 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="0.1951 0.980783 0 34.3765 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130522 0.991445 -0 -0.254401" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 -0.130526 0 65.0717 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258821 -0.965925 -0 -0.0132105" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 -0.130526 0 65.0717 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="19.9319 -26.7654 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9319 0 1 0 -26.7654 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.93181 -0.269922 0.25" />
                            <Vertex pos="1.76365 -0.765362 0.25" />
                            <Vertex pos="-1.93181 0.765362 0.25" />
                            <Vertex pos="1.93181 -0.269922 -0.25" />
                            <Vertex pos="1.76365 -0.765362 -0.25" />
                            <Vertex pos="-1.93181 0.765362 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5102.57 0 -1 0 6851.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1015.28 0 -1 0 2657.97 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946941 -0.321407 0 -1.91607" album="Blasted" material="bm_edge_white" texgens="0.321429 0.946934 0 38.6411 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.258826 0.965924 -0 -0.239279" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0526 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382687 -0.923878 -0 -0.0321763" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0526 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="19.8478 -27 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.8478 0 1 0 -27 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.84779 -0.53072 0.25" />
                            <Vertex pos="1.61633 -1.00001 0.25" />
                            <Vertex pos="-1.84779 1.00001 0.25" />
                            <Vertex pos="1.84779 -0.53072 -0.25" />
                            <Vertex pos="1.61633 -1.00001 -0.25" />
                            <Vertex pos="-1.84779 1.00001 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5081.04 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1004.52 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896849 -0.442338 0 -1.89195" album="Blasted" material="bm_edge_white" texgens="0.442291 0.896872 0 44.5024 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.382677 0.923882 -0 -0.216784" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500002 -0.866024 -0 -0.0578653" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="19.732 -27.2175 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.732 0 1 0 -27.2175 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.73207 -0.782507 0.25" />
                            <Vertex pos="1.44138 -1.21751 0.25" />
                            <Vertex pos="-1.73207 1.21751 0.25" />
                            <Vertex pos="1.73207 -0.782507 -0.25" />
                            <Vertex pos="1.44138 -1.21751 -0.25" />
                            <Vertex pos="-1.73207 1.21751 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5051.39 0 -1 0 6967.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -989.695 0 -1 0 2715.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831443 -0.55561 0 -1.87489" album="Blasted" material="bm_edge_white" texgens="0.555578 0.831465 0 51.7705 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.499999 0.866026 -0 -0.188362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4796 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608753 -0.79336 -0 -0.0884792" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4796 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="19.5867 -27.4142 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.5867 0 1 0 -27.4142 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.5867 -1.02081 0.250004" />
                            <Vertex pos="1.24173 -1.41421 0.250004" />
                            <Vertex pos="-1.5867 1.41421 0.250004" />
                            <Vertex pos="1.5867 -1.02081 -0.250004" />
                            <Vertex pos="1.24173 -1.41421 -0.250004" />
                            <Vertex pos="-1.5867 1.41421 -0.250004" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.250004" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5014.2 0 -1 0 7018.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.250004" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -971.096 0 -1 0 2741.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751871 -0.659311 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="0.659331 0.751853 0 59.8488 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.608759 0.793355 -0 -0.156053" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 0.793354 -0.608761 0 67.8327 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707106 -0.707108 -0 -0.121965" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 0.793354 -0.608761 0 67.8327 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="19.4142 -27.5867 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.4142 0 1 0 -27.5867 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.41422 -1.24173 0.25" />
                            <Vertex pos="1.02088 -1.5867 0.25" />
                            <Vertex pos="-1.41422 1.5867 0.25" />
                            <Vertex pos="1.41422 -1.24173 -0.25" />
                            <Vertex pos="1.02088 -1.5867 -0.25" />
                            <Vertex pos="-1.41422 1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4970.04 0 -1 0 7062.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -949.016 0 -1 0 2763.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659368 -0.751821 0 -1.86605" album="Blasted" material="bm_edge_white" texgens="0.751844 0.659341 0 68.1625 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707106 0.707108 -0 -0.121966" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.903 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793346 -0.608772 -0 -0.156027" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.903 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="19.2175 -27.7321 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.2175 0 1 0 -27.7321 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.21753 -1.44134 0.25" />
                            <Vertex pos="0.782467 -1.73206 0.25" />
                            <Vertex pos="-1.21753 1.73206 0.25" />
                            <Vertex pos="1.21753 -1.44134 -0.25" />
                            <Vertex pos="0.782467 -1.73206 -0.25" />
                            <Vertex pos="-1.21753 1.73206 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4919.68 0 -1 0 7099.42 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -923.839 0 -1 0 2781.71 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555597 -0.831452 0 -1.87486" album="Blasted" material="bm_edge_white" texgens="0.831468 0.555573 0 76.2514 0 0 -1 64 0 0.130811 0.125" texRot="0" texScale="0.130811 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.79335 0.608765 -0 -0.0884901" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.608763 -0.793352 0 67.6869 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866027 -0.499997 -0 -0.188388" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.608763 -0.793352 0 67.6869 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="19 -27.8478 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 -27.8478 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 -1.61636 0.25" />
                            <Vertex pos="0.53072 -1.84776 0.25" />
                            <Vertex pos="-0.999998 1.84776 0.25" />
                            <Vertex pos="1 -1.61636 -0.25" />
                            <Vertex pos="0.53072 -1.84776 -0.25" />
                            <Vertex pos="-0.999998 1.84776 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 7129.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -895.999 0 -1 0 2796.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442253 -0.89689 0 -1.89195" album="Blasted" material="bm_edge_white" texgens="0.896879 0.442276 0 83.4744 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866027 0.499998 -0 -0.0578506" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2103 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923881 -0.38268 -0 -0.216779" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2103 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="18.7654 -27.9319 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.7654 0 1 0 -27.9319 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.76536 -1.76366 0.25" />
                            <Vertex pos="0.269892 -1.93185 0.25" />
                            <Vertex pos="-0.76536 1.93185 0.25" />
                            <Vertex pos="0.76536 -1.76366 -0.25" />
                            <Vertex pos="0.269892 -1.93185 -0.25" />
                            <Vertex pos="-0.76536 1.93185 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4803.94 0 -1 0 7150.57 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -865.97 0 -1 0 2807.28 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321442 -0.946929 0 -1.91608" album="Blasted" material="bm_edge_white" texgens="0.946928 0.321446 0 89.3926 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.92388 0.382681 -0 -0.0321816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4868 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965927 -0.258814 -0 -0.239293" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4868 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="18.5176 -27.9829 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5176 0 1 0 -27.9829 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.517624 -1.88082 0.25" />
                            <Vertex pos="0.00446892 -1.98289 0.25" />
                            <Vertex pos="-0.517624 1.98288 0.25" />
                            <Vertex pos="0.517624 -1.88082 -0.25" />
                            <Vertex pos="0.00446892 -1.98289 -0.25" />
                            <Vertex pos="-0.517624 1.98288 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4740.51 0 -1 0 7163.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -834.251 0 -1 0 2813.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195085 -0.980786 0 -1.94566" album="Blasted" material="bm_edge_white" texgens="0.980787 0.19508 0 93.5393 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965928 0.258813 -0 -0.0132072" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5771 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991445 -0.130524 -0 -0.254383" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5771 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="18.261 -28 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.261 0 1 0 -28 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.261047 -1.96577 0.25" />
                            <Vertex pos="-0.261045 -1.99999 0.25" />
                            <Vertex pos="-0.261045 1.99999 0.25" />
                            <Vertex pos="0.261047 -1.96577 -0.25" />
                            <Vertex pos="-0.261045 -1.99999 -0.25" />
                            <Vertex pos="-0.261045 1.99999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4674.82 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -801.407 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0654036 -0.997859 0 -1.97863" album="Blasted" material="bm_edge_white" texgens="0.997859 0.065402 0 95.7087 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991445 0.130524 -0 -0.00223425" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5423 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.261045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5423 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="17.7389 -28 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.7389 0 1 0 -28 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.261063 -1.99999 0.25" />
                            <Vertex pos="-0.261061 -1.96578 0.25" />
                            <Vertex pos="0.261063 2 0.25" />
                            <Vertex pos="0.261063 -1.99999 -0.25" />
                            <Vertex pos="-0.261061 -1.96578 -0.25" />
                            <Vertex pos="0.261063 2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4541.16 0 -1 0 7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -734.578 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0653806 -0.99786 -0 -1.97864" album="Blasted" material="bm_edge_white" texgens="0.997859 -0.0654019 0 32.2612 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.002 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991444 0.130531 0 -0.0022324" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.002 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="17.4824 -27.9829 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.4824 0 1 0 -27.9829 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.00448227 -1.98292 0.25" />
                            <Vertex pos="-0.517641 -1.88083 0.25" />
                            <Vertex pos="0.517641 1.98292 0.25" />
                            <Vertex pos="-0.00448227 -1.98292 -0.25" />
                            <Vertex pos="-0.517641 -1.88083 -0.25" />
                            <Vertex pos="0.517641 1.98292 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4475.49 0 -1 0 7163.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -701.746 0 -1 0 2813.81 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.19512 -0.980779 -0 -1.94568" album="Blasted" material="bm_edge_white" texgens="0.980784 -0.195098 0 34.459 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991445 -0.130529 0 -0.254384" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.13053 -0.991444 0 65.0698 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965926 0.258817 0 -0.0132114" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.13053 -0.991444 0 65.0698 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="17.2346 -27.9318 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.2346 0 1 0 -27.9318 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.269917 -1.93186 0.25" />
                            <Vertex pos="-0.765385 -1.76367 0.25" />
                            <Vertex pos="0.765383 1.93186 0.25" />
                            <Vertex pos="-0.269917 -1.93186 -0.25" />
                            <Vertex pos="-0.765385 -1.76367 -0.25" />
                            <Vertex pos="0.765383 1.93186 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4412.06 0 -1 0 7150.54 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -670.028 0 -1 0 2807.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321442 -0.946929 -0 -1.9161" album="Blasted" material="bm_edge_white" texgens="0.946928 -0.321446 0 38.6265 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965925 -0.258824 0 -0.239291" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0508 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923877 0.38269 0 -0.0321831" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0508 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="17 -27.8478 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -27.8478 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.530718 -1.84774 0.25" />
                            <Vertex pos="-0.999998 -1.61633 0.25" />
                            <Vertex pos="1 1.84774 0.25" />
                            <Vertex pos="-0.530718 -1.84774 -0.25" />
                            <Vertex pos="-0.999998 -1.61633 -0.25" />
                            <Vertex pos="1 1.84774 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 7129.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -639.999 0 -1 0 2796.52 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442268 -0.896883 -0 -1.89193" album="Blasted" material="bm_edge_white" texgens="0.896872 -0.442291 0 44.5313 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.92388 -0.382683 0 -0.21678" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866024 0.500003 0 -0.0578519" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8735 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="16.7825 -27.732 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.7825 0 1 0 -27.732 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.782537 -1.73206 0.25" />
                            <Vertex pos="-1.21754 -1.44137 0.25" />
                            <Vertex pos="1.21754 1.73207 0.25" />
                            <Vertex pos="-0.782537 -1.73206 -0.25" />
                            <Vertex pos="-1.21754 -1.44137 -0.25" />
                            <Vertex pos="1.21754 1.73207 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4296.32 0 -1 0 7099.39 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -612.159 0 -1 0 2781.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.55561 -0.831443 -0 -1.87489" album="Blasted" material="bm_edge_white" texgens="0.831464 -0.555578 0 51.7764 0 0 -1 64 0 0.130796 0.125" texRot="0" texScale="0.130796 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866019 -0.500011 0 -0.188358" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.4797 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793352 0.608764 0 -0.0884838" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.4797 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="16.5858 -27.5867 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.5858 0 1 0 -27.5867 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.02083 -1.58671 0.25" />
                            <Vertex pos="-1.41421 -1.24174 0.25" />
                            <Vertex pos="1.41421 1.58671 0.25" />
                            <Vertex pos="-1.02083 -1.58671 -0.25" />
                            <Vertex pos="-1.41421 -1.24174 -0.25" />
                            <Vertex pos="1.41421 1.58671 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4245.96 0 -1 0 7062.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -586.981 0 -1 0 2763.1 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.65933 -0.751854 -0 -1.86604" album="Blasted" material="bm_edge_white" texgens="0.751844 -0.659341 0 59.8452 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.793355 -0.60876 0 -0.156045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8317 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707111 0.707103 0 -0.121965" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8317 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="16.4133 -27.4142 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.4133 0 1 0 -27.4142 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.24171 -1.41423 0.25" />
                            <Vertex pos="-1.58671 -1.02088 0.25" />
                            <Vertex pos="1.58672 1.41423 0.25" />
                            <Vertex pos="-1.24171 -1.41423 -0.25" />
                            <Vertex pos="-1.58671 -1.02088 -0.25" />
                            <Vertex pos="1.58672 1.41423 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4201.8 0 -1 0 7018.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -564.901 0 -1 0 2741.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751801 -0.65939 -0 -1.86605" album="Blasted" material="bm_edge_white" texgens="0.659351 -0.751835 0 68.1348 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707111 -0.707103 0 -0.12198" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.902 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.60877 0.793347 0 -0.156028" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.902 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="16.268 -27.2175 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.268 0 1 0 -27.2175 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.44137 -1.21752 0.25" />
                            <Vertex pos="-1.73205 -0.782463 0.25" />
                            <Vertex pos="1.73205 1.21752 0.25" />
                            <Vertex pos="-1.44137 -1.21752 -0.25" />
                            <Vertex pos="-1.73205 -0.782463 -0.25" />
                            <Vertex pos="1.73205 1.21752 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4164.61 0 -1 0 6967.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -546.303 0 -1 0 2715.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.831484 -0.555549 -0 -1.87487" album="Blasted" material="bm_edge_white" texgens="0.555569 -0.83147 0 76.2974 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.60876 -0.793355 0 -0.0884771" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6902 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.499997 0.866027 0 -0.188386" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6902 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="16.1523 -27 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.1523 0 1 0 -27 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.61638 -1.00001 0.25" />
                            <Vertex pos="-1.84779 -0.530758 0.25" />
                            <Vertex pos="1.84779 1.00001 0.25" />
                            <Vertex pos="-1.61638 -1.00001 -0.25" />
                            <Vertex pos="-1.84779 -0.530758 -0.25" />
                            <Vertex pos="1.84779 1.00001 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4134.99 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -531.493 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.896872 -0.44229 -0 -1.89198" album="Blasted" material="bm_edge_white" texgens="0.442299 -0.896868 0 83.5527 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.499996 -0.866028 0 -0.0578521" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.205 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382685 0.923879 0 -0.216766" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.205 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="16.0682 -26.7654 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0682 0 1 0 -26.7654 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.76363 -0.765368 0.25" />
                            <Vertex pos="-1.93181 -0.269909 0.25" />
                            <Vertex pos="1.93181 0.765366 0.25" />
                            <Vertex pos="-1.76363 -0.765368 -0.25" />
                            <Vertex pos="-1.93181 -0.269909 -0.25" />
                            <Vertex pos="1.93181 0.765366 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4113.46 0 -1 0 6851.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -520.728 0 -1 0 2657.97 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946933 -0.32143 -0 -1.91605" album="Blasted" material="bm_edge_white" texgens="0.321446 -0.946928 0 89.3926 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.38269 -0.923877 0 -0.0321813" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258824 0.965925 0 -0.239287" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="16.0171 -26.5176 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0171 0 1 0 -26.5176 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.88079 -0.517643 0.25" />
                            <Vertex pos="-1.98288 -0.00448418 0.25" />
                            <Vertex pos="1.98288 0.517643 0.25" />
                            <Vertex pos="-1.88079 -0.517643 -0.25" />
                            <Vertex pos="-1.98288 -0.00448418 -0.25" />
                            <Vertex pos="1.98288 0.517643 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4100.38 0 -1 0 6788.51 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -514.188 0 -1 0 2626.25 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980779 -0.19512 -0 -1.94564" album="Blasted" material="bm_edge_white" texgens="0.195097 -0.980784 0 93.564 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.258823 -0.965925 0 -0.0132117" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5776 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130532 0.991444 0 -0.254384" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5776 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="16 -26.2611 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -26.2611 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.96578 -0.261065 0.25" />
                            <Vertex pos="-2 0.261063 0.25" />
                            <Vertex pos="2 0.261063 0.25" />
                            <Vertex pos="-1.96578 -0.261065 -0.25" />
                            <Vertex pos="-2 0.261063 -0.25" />
                            <Vertex pos="2 0.261063 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 6722.84 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 2593.42 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.997859 -0.0653991 -0 -1.97865" album="Blasted" material="bm_edge_white" texgens="0.0654018 -0.997859 0 95.7148 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130532 -0.991444 0 -0.0022344" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5418 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 1 0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5418 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="16 -25.739 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -25.739 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.99996 -0.26103 0.25" />
                            <Vertex pos="-1.96575 0.26103 0.25" />
                            <Vertex pos="1.99996 -0.26103 0.25" />
                            <Vertex pos="-1.99996 -0.26103 -0.25" />
                            <Vertex pos="-1.96575 0.26103 -0.25" />
                            <Vertex pos="1.99996 -0.26103 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 6589.18 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 2526.59 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.99786 0.0653886 0 -1.97861" album="Blasted" material="bm_edge_white" texgens="-0.0654019 -0.997859 0 32.2661 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.26103" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9991 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130517 0.991446 0 -0.00223252" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9991 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="16.0171 -25.4824 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0171 0 1 0 -25.4824 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.9829 0.00445175 0.249996" />
                            <Vertex pos="-1.88084 0.517639 0.249996" />
                            <Vertex pos="1.9829 -0.517639 0.249996" />
                            <Vertex pos="-1.9829 0.00445175 -0.249996" />
                            <Vertex pos="-1.88084 0.517639 -0.249996" />
                            <Vertex pos="1.9829 -0.517639 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.249996" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4100.38 0 -1 0 6523.49 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.249996" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -514.188 0 -1 0 2493.75 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980792 0.195055 0 -1.94568" album="Blasted" material="bm_edge_white" texgens="-0.195078 -0.980788 0 34.4702 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130522 -0.991445 0 -0.254399" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.991445 0.130524 0 65.0709 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258817 0.965926 0 -0.0132074" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.991445 0.130524 0 65.0709 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="16.0681 -25.2346 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0681 0 1 0 -25.2346 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.93186 0.269924 0.25" />
                            <Vertex pos="-1.76368 0.765356 0.25" />
                            <Vertex pos="1.93186 -0.765354 0.25" />
                            <Vertex pos="-1.93186 0.269924 -0.25" />
                            <Vertex pos="-1.76368 0.765356 -0.25" />
                            <Vertex pos="1.93186 -0.765354 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4113.43 0 -1 0 6460.06 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -520.716 0 -1 0 2462.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946928 0.321445 0 -1.9161" album="Blasted" material="bm_edge_white" texgens="-0.321446 -0.946928 0 38.6138 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258818 -0.965926 0 -0.239274" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.0519 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.382676 0.923882 0 -0.0321802" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.0519 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="16.1522 -25 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.1522 0 1 0 -25 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.84776 0.530714 0.25" />
                            <Vertex pos="-1.61633 0.999996 0.25" />
                            <Vertex pos="1.84776 -0.999996 0.25" />
                            <Vertex pos="-1.84776 0.530714 -0.25" />
                            <Vertex pos="-1.61633 0.999996 -0.25" />
                            <Vertex pos="1.84776 -0.999996 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4134.96 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -531.48 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.896868 0.442297 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="-0.442299 -0.896868 0 44.4832 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.382678 -0.923882 0 -0.216781" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8734 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.5 0.866026 0 -0.0578575" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8734 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="16.268 -24.7825 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.268 0 1 0 -24.7825 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.73207 0.782501 0.25" />
                            <Vertex pos="-1.44138 1.21753 0.25" />
                            <Vertex pos="1.73207 -1.21753 0.25" />
                            <Vertex pos="-1.73207 0.782501 -0.25" />
                            <Vertex pos="-1.44138 1.21753 -0.25" />
                            <Vertex pos="1.73207 -1.21753 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4164.61 0 -1 0 6344.32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -546.303 0 -1 0 2404.16 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.831458 0.555587 0 -1.87489" album="Blasted" material="bm_edge_white" texgens="-0.555556 -0.83148 0 51.7825 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.500002 -0.866024 0 -0.188373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4811 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608759 0.793355 0 -0.0884801" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4811 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="16.4133 -24.5858 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.4133 0 1 0 -24.5858 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.58671 1.02081 0.250004" />
                            <Vertex pos="-1.24174 1.41422 0.250004" />
                            <Vertex pos="1.58671 -1.41422 0.250004" />
                            <Vertex pos="-1.58671 1.02081 -0.250004" />
                            <Vertex pos="-1.24174 1.41422 -0.250004" />
                            <Vertex pos="1.58671 -1.41422 -0.250004" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.250004" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4201.8 0 -1 0 6293.96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.250004" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -564.901 0 -1 0 2378.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751879 0.659301 0 -1.86604" album="Blasted" material="bm_edge_white" texgens="-0.659351 -0.751835 0 59.8265 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608758 -0.793356 0 -0.156057" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.793355 0.60876 0 67.8299 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707106 0.707108 0 -0.121965" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.793355 0.60876 0 67.8299 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="16.5858 -24.4133 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.5858 0 1 0 -24.4133 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.41422 1.2417 0.25" />
                            <Vertex pos="-1.02084 1.5867 0.25" />
                            <Vertex pos="1.41422 -1.5867 0.25" />
                            <Vertex pos="-1.41422 1.2417 -0.25" />
                            <Vertex pos="-1.02084 1.5867 -0.25" />
                            <Vertex pos="1.41422 -1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4245.96 0 -1 0 6249.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -586.981 0 -1 0 2356.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.659362 0.751826 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="-0.751835 -0.659351 0 68.1821 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707102 -0.707112 0 -0.121977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9031 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.79335 0.608765 0 -0.156044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9031 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="16.7825 -24.268 33.25" rot="1 0 0 0" scale="" transform="1 0 0 16.7825 0 1 0 -24.268 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.21753 1.44137 0.25" />
                            <Vertex pos="-0.782469 1.73206 0.25" />
                            <Vertex pos="1.21753 -1.73206 0.25" />
                            <Vertex pos="-1.21753 1.44137 -0.25" />
                            <Vertex pos="-0.782469 1.73206 -0.25" />
                            <Vertex pos="1.21753 -1.73206 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4296.32 0 -1 0 6212.61 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -612.159 0 -1 0 2338.3 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.555559 0.831477 0 -1.87488" album="Blasted" material="bm_edge_white" texgens="-0.831471 -0.555569 0 76.2469 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.793353 -0.608762 0 -0.0884804" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866027 0.499998 0 -0.188387" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="17 -24.1522 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -24.1522 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.999998 1.61633 0.25" />
                            <Vertex pos="-0.530716 1.84776 0.25" />
                            <Vertex pos="1 -1.84776 0.25" />
                            <Vertex pos="-0.999998 1.61633 -0.25" />
                            <Vertex pos="-0.530716 1.84776 -0.25" />
                            <Vertex pos="1 -1.84776 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 6182.96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -639.999 0 -1 0 2323.48 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442297 0.896868 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="-0.896872 -0.442291 0 83.4872 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866025 -0.500001 0 -0.0578568" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.2048 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923881 0.382679 0 -0.216781" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.2048 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="17.2346 -24.0682 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.2346 0 1 0 -24.0682 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.765358 1.7637 0.249996" />
                            <Vertex pos="-0.26992 1.93186 0.249996" />
                            <Vertex pos="0.765358 -1.93186 0.249996" />
                            <Vertex pos="-0.765358 1.7637 -0.249996" />
                            <Vertex pos="-0.26992 1.93186 -0.249996" />
                            <Vertex pos="0.765358 -1.93186 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.249996" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4412.06 0 -1 0 6161.46 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.249996" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -670.028 0 -1 0 2312.73 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321408 0.946941 0 -1.91611" album="Blasted" material="bm_edge_white" texgens="-0.946934 -0.321429 0 89.3738 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.923883 -0.382676 0 -0.0321754" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.382683 0.92388 0 66.4851 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965926 0.258818 0 -0.239278" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00012 -0.382683 0.92388 0 66.4851 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="17.4824 -24.0171 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.4824 0 1 0 -24.0171 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.517635 1.88077 0.25" />
                            <Vertex pos="-0.00445175 1.98289 0.25" />
                            <Vertex pos="0.517637 -1.98289 0.25" />
                            <Vertex pos="-0.517635 1.88077 -0.25" />
                            <Vertex pos="-0.00445175 1.98289 -0.25" />
                            <Vertex pos="0.517637 -1.98289 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4475.49 0 -1 0 6148.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -701.746 0 -1 0 2306.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.195167 0.98077 0 -1.94563" album="Blasted" material="bm_edge_white" texgens="-0.980784 -0.195099 0 93.5906 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965925 -0.258821 0 -0.0132144" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.5787 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991445 0.130522 0 -0.254398" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.5787 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="17.739 -24 33.25" rot="1 0 0 0" scale="" transform="1 0 0 17.739 0 1 0 -24 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.261047 1.96578 0.25" />
                            <Vertex pos="0.261047 2 0.25" />
                            <Vertex pos="0.261047 -2 0.25" />
                            <Vertex pos="-0.261047 1.96578 -0.25" />
                            <Vertex pos="0.261047 2 -0.25" />
                            <Vertex pos="0.261047 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4541.18 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -734.591 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0654034 0.997859 0 -1.97864" album="Blasted" material="bm_edge_white" texgens="-0.997859 -0.0654019 0 95.7375 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991445 -0.130524 0 -0.00223324" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.130525 0.991445 0 64.5429 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="1 -0 0 -0.261047" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.130525 0.991445 0 64.5429 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="18.2611 -24 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.2611 0 1 0 -24 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.261063 2.00001 0.25" />
                            <Vertex pos="0.261065 1.96579 0.25" />
                            <Vertex pos="-0.261063 -2.00001 0.25" />
                            <Vertex pos="-0.261063 2.00001 -0.25" />
                            <Vertex pos="0.261065 1.96579 -0.25" />
                            <Vertex pos="-0.261063 -2.00001 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4674.84 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -801.42 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0653991 0.997859 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="-0.997859 0.065402 0 32.2285 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991444 -0.130531 0 -0.00223437" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9988 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="18.5176 -24.0171 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5176 0 1 0 -24.0171 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.00445175 1.98289 0.25" />
                            <Vertex pos="0.517645 1.8808 0.25" />
                            <Vertex pos="-0.517645 -1.98289 0.25" />
                            <Vertex pos="0.00445175 1.98289 -0.25" />
                            <Vertex pos="0.517645 1.8808 -0.25" />
                            <Vertex pos="-0.517645 -1.98289 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4740.51 0 -1 0 6148.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -834.251 0 -1 0 2306.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195108 0.980782 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="-0.980784 0.195098 0 34.4375 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991445 0.130524 0 -0.254401" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0708 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 -0.258823 0 -0.0132117" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0708 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="18.7654 -24.0681 33.25" rot="1 0 0 0" scale="" transform="1 0 0 18.7654 0 1 0 -24.0681 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.269905 1.93181 0.25" />
                            <Vertex pos="0.765371 1.76366 0.25" />
                            <Vertex pos="-0.765371 -1.93181 0.25" />
                            <Vertex pos="0.269905 1.93181 -0.25" />
                            <Vertex pos="0.765371 1.76366 -0.25" />
                            <Vertex pos="-0.765371 -1.93181 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4803.94 0 -1 0 6161.43 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -865.97 0 -1 0 2312.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321374 0.946952 0 -1.91607" album="Blasted" material="bm_edge_white" texgens="-0.946928 0.321446 0 38.6548 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965924 0.258824 0 -0.239291" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923877 -0.382689 0 -0.0321746" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0516 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="19 -24.1523 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 -24.1523 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.530752 1.84777 0.25" />
                            <Vertex pos="1 1.61636 0.25" />
                            <Vertex pos="-1 -1.84777 0.25" />
                            <Vertex pos="0.530752 1.84777 -0.25" />
                            <Vertex pos="1 1.61636 -0.25" />
                            <Vertex pos="-1 -1.84777 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 6182.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -895.999 0 -1 0 2323.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442293 0.896871 0 -1.89196" album="Blasted" material="bm_edge_white" texgens="-0.896879 0.442276 0 44.561 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.923879 0.382685 0 -0.216764" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866027 -0.499997 0 -0.0578521" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8724 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="19.2175 -24.268 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.2175 0 1 0 -24.268 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.782459 1.73201 0.25" />
                            <Vertex pos="1.21752 1.44135 0.25" />
                            <Vertex pos="-1.21752 -1.73201 0.25" />
                            <Vertex pos="0.782459 1.73201 -0.25" />
                            <Vertex pos="1.21752 1.44135 -0.25" />
                            <Vertex pos="-1.21752 -1.73201 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4919.68 0 -1 0 6212.61 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -923.839 0 -1 0 2338.3 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555519 0.831504 0 -1.87484" album="Blasted" material="bm_edge_white" texgens="-0.831465 0.555578 0 51.7114 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866023 0.500005 0 -0.188386" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4815 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.793349 -0.608767 0 -0.0884721" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4815 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="19.4142 -24.4133 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.4142 0 1 0 -24.4133 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.02086 1.5867 0.25" />
                            <Vertex pos="1.41424 1.2417 0.25" />
                            <Vertex pos="-1.41424 -1.5867 0.25" />
                            <Vertex pos="1.02086 1.5867 -0.25" />
                            <Vertex pos="1.41424 1.2417 -0.25" />
                            <Vertex pos="-1.41424 -1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4970.04 0 -1 0 6249.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -949.016 0 -1 0 2356.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659362 0.751826 0 -1.86604" album="Blasted" material="bm_edge_white" texgens="-0.751835 0.659351 0 59.814 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.793346 0.608772 0 -0.156043" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8319 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707097 -0.707117 0 -0.121978" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8319 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="19.5867 -24.5858 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.5867 0 1 0 -24.5858 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.24176 1.41424 0.25" />
                            <Vertex pos="1.5867 1.02083 0.25" />
                            <Vertex pos="-1.5867 -1.41424 0.25" />
                            <Vertex pos="1.24176 1.41424 -0.25" />
                            <Vertex pos="1.5867 1.02083 -0.25" />
                            <Vertex pos="-1.5867 -1.41424 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5014.2 0 -1 0 6293.96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -971.096 0 -1 0 2378.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751907 0.659269 0 -1.86605" album="Blasted" material="bm_edge_white" texgens="-0.659351 0.751835 0 68.1577 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707109 0.707104 0 -0.121955" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608767 -0.793349 0 -0.156056" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="19.7321 -24.7825 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.7321 0 1 0 -24.7825 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.44134 1.21751 0.25" />
                            <Vertex pos="1.73207 0.782507 0.25" />
                            <Vertex pos="-1.73207 -1.21751 0.25" />
                            <Vertex pos="1.44134 1.21751 -0.25" />
                            <Vertex pos="1.73207 0.782507 -0.25" />
                            <Vertex pos="-1.73207 -1.21751 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5051.42 0 -1 0 6344.32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -989.708 0 -1 0 2404.16 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831408 0.555663 0 -1.87487" album="Blasted" material="bm_edge_white" texgens="-0.555569 0.831471 0 76.2427 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608758 0.793356 0 -0.0884922" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.69 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.499999 -0.866026 0 -0.188362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.69 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="19.8478 -25 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.8478 0 1 0 -25 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.61634 0.99999 0.25" />
                            <Vertex pos="1.84774 0.530714 0.25" />
                            <Vertex pos="-1.84774 -0.99999 0.25" />
                            <Vertex pos="1.61634 0.99999 -0.25" />
                            <Vertex pos="1.84774 0.530714 -0.25" />
                            <Vertex pos="-1.84774 -0.99999 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5081.04 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1004.52 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896889 0.442256 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="-0.442276 0.896879 0 83.4424 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499999 0.866026 0 -0.0578499" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2081 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.38268 -0.923881 0 -0.216778" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2081 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="19.9318 -25.2346 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9318 0 1 0 -25.2346 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.76372 0.765381 0.25" />
                            <Vertex pos="1.9319 0.269909 0.25" />
                            <Vertex pos="-1.9319 -0.765381 0.25" />
                            <Vertex pos="1.76372 0.765381 -0.25" />
                            <Vertex pos="1.9319 0.269909 -0.25" />
                            <Vertex pos="-1.9319 -0.765381 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5102.54 0 -1 0 6460.06 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1015.27 0 -1 0 2462.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946936 0.321422 0 -1.91614" album="Blasted" material="bm_edge_white" texgens="-0.321446 0.946928 0 89.3911 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.38268 0.923881 0 -0.0321796" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4853 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258816 -0.965927 0 -0.239295" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4853 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="19.9829 -25.4824 33.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9829 0 1 0 -25.4824 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.88083 0.517624 0.25" />
                            <Vertex pos="1.98289 0.0044651 0.25" />
                            <Vertex pos="-1.98289 -0.517624 0.25" />
                            <Vertex pos="1.88083 0.517624 -0.25" />
                            <Vertex pos="1.98289 0.0044651 -0.25" />
                            <Vertex pos="-1.98289 -0.517624 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5115.62 0 -1 0 6523.49 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1021.81 0 -1 0 2493.75 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.98079 0.195065 0 -1.94567" album="Blasted" material="bm_edge_white" texgens="-0.195079 0.980788 0 93.5264 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258811 0.965928 0 -0.0132071" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.5772 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130522 -0.991445 0 -0.254385" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.5772 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="20 -25.739 33.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -25.739 0 0 1 33.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.96579 0.26103 0.25" />
                            <Vertex pos="2 -0.261032 0.25" />
                            <Vertex pos="-2.00001 -0.261032 0.25" />
                            <Vertex pos="1.96579 0.26103 -0.25" />
                            <Vertex pos="2 -0.261032 -0.25" />
                            <Vertex pos="-2.00001 -0.261032 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5120 0 -1 0 6589.18 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 2526.59 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.99786 0.0653883 0 -1.97865" album="Blasted" material="bm_edge_white" texgens="-0.0654041 0.997859 0 95.7227 0 0 -1 64 0 0.130802 0.125" texRot="0" texScale="0.130802 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130515 0.991446 0 -0.00223213" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 0.130522 0 64.5426 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.261032" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 0.130522 0 64.5426 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="20 -10.261 32.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -10.261 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="2 0.261063 0.25" />
                            <Vertex pos="1.96578 -0.261064 0.25" />
                            <Vertex pos="-2 0.261063 0.25" />
                            <Vertex pos="2 0.261063 -0.25" />
                            <Vertex pos="1.96578 -0.261064 -0.25" />
                            <Vertex pos="-2 0.261063 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5120 0 -1 0 2626.82 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 545.408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.997859 -0.0653993 0 -1.97865" album="Blasted" material="bm_edge_white" texgens="0.0654019 0.997859 0 32.2585 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 1 -0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9999 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130532 -0.991444 -0 -0.00223392" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 1 0 0 63.9999 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="19.9829 -10.5176 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9829 0 1 0 -10.5176 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.98289 -0.00445271 0.25" />
                            <Vertex pos="1.8808 -0.517641 0.25" />
                            <Vertex pos="-1.98289 0.517641 0.25" />
                            <Vertex pos="1.98289 -0.00445271 -0.249996" />
                            <Vertex pos="1.8808 -0.517641 -0.249996" />
                            <Vertex pos="-1.98289 0.517641 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5115.62 0 -1 0 2692.51 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.249996" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1021.81 0 -1 0 578.253 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.980781 -0.19511 0 -1.94565" album="Blasted" material="bm_edge_white" texgens="0.1951 0.980783 0 34.4353 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130523 0.991445 -0 -0.254399" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 -0.130526 0 65.0713 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258821 -0.965925 -0 -0.0132115" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 0.991445 -0.130526 0 65.0713 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="19.9318 -10.7654 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9318 0 1 0 -10.7654 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.93182 -0.269921 0.25" />
                            <Vertex pos="1.76367 -0.765357 0.25" />
                            <Vertex pos="-1.93182 0.765357 0.25" />
                            <Vertex pos="1.93182 -0.269921 -0.25" />
                            <Vertex pos="1.76367 -0.765357 -0.25" />
                            <Vertex pos="-1.93182 0.765357 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5102.54 0 -1 0 2755.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1015.27 0 -1 0 609.971 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946946 -0.321392 0 -1.91608" album="Blasted" material="bm_edge_white" texgens="0.321429 0.946934 0 38.6181 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.258823 0.965925 -0 -0.239277" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0515 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382682 -0.92388 -0 -0.0321741" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965926 -0.258818 0 66.0515 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="19.8478 -11 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.8478 0 1 0 -11 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.84776 -0.530719 0.25" />
                            <Vertex pos="1.61633 -0.999999 0.25" />
                            <Vertex pos="-1.84776 0.999998 0.25" />
                            <Vertex pos="1.84776 -0.530719 -0.25" />
                            <Vertex pos="1.61633 -0.999999 -0.25" />
                            <Vertex pos="-1.84776 0.999998 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5081.04 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1004.52 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896868 -0.442299 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="0.442291 0.896872 0 44.5146 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.38268 0.923881 -0 -0.216779" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8738 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500001 -0.866025 -0 -0.057858" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.92388 -0.382683 0 66.8738 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="19.732 -11.2175 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.732 0 1 0 -11.2175 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.73206 -0.782454 0.25" />
                            <Vertex pos="1.44138 -1.21752 0.25" />
                            <Vertex pos="-1.73206 1.21752 0.25" />
                            <Vertex pos="1.73206 -0.782454 -0.25" />
                            <Vertex pos="1.44138 -1.21752 -0.25" />
                            <Vertex pos="-1.73206 1.21752 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5051.39 0 -1 0 2871.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -989.695 0 -1 0 667.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831489 -0.555541 0 -1.87487" album="Blasted" material="bm_edge_white" texgens="0.555578 0.831465 0 51.7503 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.499993 0.866029 -0 -0.18839" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4791 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608757 -0.793356 -0 -0.0884768" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866025 -0.5 0 67.4791 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="19.5867 -11.4142 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.5867 0 1 0 -11.4142 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.5867 -1.02081 0.25" />
                            <Vertex pos="1.24173 -1.41422 0.25" />
                            <Vertex pos="-1.5867 1.41422 0.25" />
                            <Vertex pos="1.5867 -1.02081 -0.25" />
                            <Vertex pos="1.24173 -1.41422 -0.25" />
                            <Vertex pos="-1.5867 1.41422 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5014.2 0 -1 0 2922.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -971.096 0 -1 0 693.018 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751879 -0.659301 0 -1.86603" album="Blasted" material="bm_edge_white" texgens="0.659331 0.751853 0 59.8337 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.608761 0.793354 -0 -0.156057" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793354 -0.608761 0 67.8317 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707108 -0.707106 -0 -0.121966" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793354 -0.608761 0 67.8317 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="19.4142 -11.5867 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.4142 0 1 0 -11.5867 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.41421 -1.24173 0.25" />
                            <Vertex pos="1.02087 -1.5867 0.25" />
                            <Vertex pos="-1.41421 1.5867 0.25" />
                            <Vertex pos="1.41421 -1.24173 -0.25" />
                            <Vertex pos="1.02087 -1.5867 -0.25" />
                            <Vertex pos="-1.41421 1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4970.04 0 -1 0 2966.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -949.016 0 -1 0 715.098 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659368 -0.751821 0 -1.86604" album="Blasted" material="bm_edge_white" texgens="0.751844 0.659341 0 68.1719 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707108 0.707106 -0 -0.121965" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.793348 -0.608768 -0 -0.156028" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707107 -0.707107 0 67.9024 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="19.2175 -11.7321 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.2175 0 1 0 -11.7321 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.21753 -1.44134 0.25" />
                            <Vertex pos="0.782467 -1.73206 0.25" />
                            <Vertex pos="-1.21753 1.73206 0.25" />
                            <Vertex pos="1.21753 -1.44134 -0.25" />
                            <Vertex pos="0.782467 -1.73206 -0.25" />
                            <Vertex pos="-1.21753 1.73206 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4919.68 0 -1 0 3003.42 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -923.839 0 -1 0 733.709 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555597 -0.831452 0 -1.87486" album="Blasted" material="bm_edge_white" texgens="0.831468 0.555573 0 76.2515 0 0 -1 64 0 0.130811 0.125" texRot="0" texScale="0.130811 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.79335 0.608765 -0 -0.0884901" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 -0.793352 0 67.6907 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866027 -0.499997 -0 -0.188388" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 -0.793352 0 67.6907 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="19 -11.8478 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 -11.8478 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.999994 -1.61635 0.25" />
                            <Vertex pos="0.530718 -1.84776 0.25" />
                            <Vertex pos="-0.999992 1.84776 0.25" />
                            <Vertex pos="0.999994 -1.61635 -0.25" />
                            <Vertex pos="0.530718 -1.84776 -0.25" />
                            <Vertex pos="-0.999992 1.84776 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 3033.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -895.999 0 -1 0 748.519 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442271 -0.896881 0 -1.89194" album="Blasted" material="bm_edge_white" texgens="0.896879 0.442276 0 83.4807 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866027 0.499996 -0 -0.0578529" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2068 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923882 -0.382678 -0 -0.216777" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.499997 -0.866027 0 67.2068 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="18.7654 -11.9319 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.7654 0 1 0 -11.9319 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.76536 -1.76367 0.25" />
                            <Vertex pos="0.269892 -1.93186 0.25" />
                            <Vertex pos="-0.765358 1.93186 0.25" />
                            <Vertex pos="0.76536 -1.76367 -0.25" />
                            <Vertex pos="0.269892 -1.93186 -0.25" />
                            <Vertex pos="-0.765358 1.93186 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4803.94 0 -1 0 3054.57 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -865.97 0 -1 0 759.283 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321442 -0.946929 0 -1.91609" album="Blasted" material="bm_edge_white" texgens="0.946928 0.321446 0 89.3843 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.923881 0.382679 -0 -0.0321823" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4863 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965928 -0.258812 -0 -0.239292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.38268 -0.923881 0 66.4863 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="18.5176 -11.9829 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5176 0 1 0 -11.9829 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.517626 -1.88083 0.25" />
                            <Vertex pos="0.00446892 -1.98289 0.25" />
                            <Vertex pos="-0.517626 1.98289 0.25" />
                            <Vertex pos="0.517626 -1.88083 -0.25" />
                            <Vertex pos="0.00446892 -1.98289 -0.25" />
                            <Vertex pos="-0.517626 1.98289 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4740.51 0 -1 0 3067.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -834.251 0 -1 0 765.811 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195066 -0.98079 0 -1.94567" album="Blasted" material="bm_edge_white" texgens="0.980787 0.19508 0 93.5732 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965928 0.258812 -0 -0.0132072" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5773 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991445 -0.130524 -0 -0.254384" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.258815 -0.965927 0 65.5773 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="18.261 -12 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.261 0 1 0 -12 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.261063 -1.96579 0.25" />
                            <Vertex pos="-0.261065 -2.00001 0.25" />
                            <Vertex pos="-0.261065 2.00001 0.25" />
                            <Vertex pos="0.261063 -1.96579 -0.25" />
                            <Vertex pos="-0.261065 -2.00001 -0.25" />
                            <Vertex pos="-0.261065 2.00001 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4674.82 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -801.407 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0653991 -0.997859 0 -1.97866" album="Blasted" material="bm_edge_white" texgens="0.997859 0.065402 0 95.689 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991444 0.130531 -0 -0.0022324" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5419 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-1 -0 -0 -0.261065" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130523 -0.991445 0 64.5419 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="17.7389 -12 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.7389 0 1 0 -12 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.261063 -2 0.25" />
                            <Vertex pos="-0.261065 -1.96578 0.25" />
                            <Vertex pos="0.261063 2 0.25" />
                            <Vertex pos="0.261063 -2 -0.25" />
                            <Vertex pos="-0.261065 -1.96578 -0.25" />
                            <Vertex pos="0.261063 2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4541.16 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -734.578 0 -1 0 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0653991 -0.997859 -0 -1.97865" album="Blasted" material="bm_edge_white" texgens="0.997859 -0.0654019 0 32.2769 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="1 0 0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.002 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.991444 0.130532 0 -0.0022344" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 -1 0 64.002 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="17.4824 -11.9829 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.4824 0 1 0 -11.9829 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.00448418 -1.98287 0.25" />
                            <Vertex pos="-0.517637 -1.88078 0.25" />
                            <Vertex pos="0.517637 1.98287 0.25" />
                            <Vertex pos="-0.00448418 -1.98287 -0.249996" />
                            <Vertex pos="-0.517637 -1.88078 -0.249996" />
                            <Vertex pos="0.517637 1.98287 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4475.49 0 -1 0 3067.62 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.249996" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -701.746 0 -1 0 765.811 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.195123 -0.980779 -0 -1.94563" album="Blasted" material="bm_edge_white" texgens="0.980784 -0.195098 0 34.4438 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.991444 -0.130532 0 -0.254381" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 -0.13053 -0.991444 0 65.0721 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.965925 0.258822 0 -0.0132115" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 -0.13053 -0.991444 0 65.0721 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="17.2346 -11.9318 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.2346 0 1 0 -11.9318 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.269905 -1.93185 0.25" />
                            <Vertex pos="-0.765371 -1.76367 0.25" />
                            <Vertex pos="0.765373 1.93185 0.25" />
                            <Vertex pos="-0.269905 -1.93185 -0.25" />
                            <Vertex pos="-0.765371 -1.76367 -0.25" />
                            <Vertex pos="0.765373 1.93185 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4412.06 0 -1 0 3054.54 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -670.028 0 -1 0 759.271 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321426 -0.946935 -0 -1.91609" album="Blasted" material="bm_edge_white" texgens="0.946928 -0.321446 0 38.6387 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.965926 -0.25882 0 -0.239293" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0517 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.923879 0.382685 0 -0.0321792" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258823 -0.965925 0 66.0517 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="17 -11.8478 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -11.8478 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.530733 -1.84774 0.25" />
                            <Vertex pos="-1.00002 -1.6163 0.25" />
                            <Vertex pos="1.00001 1.84774 0.25" />
                            <Vertex pos="-0.530733 -1.84774 -0.25" />
                            <Vertex pos="-1.00002 -1.6163 -0.25" />
                            <Vertex pos="1.00001 1.84774 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 3033.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -639.999 0 -1 0 748.519 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442309 -0.896863 -0 -1.89192" album="Blasted" material="bm_edge_white" texgens="0.896872 -0.442291 0 44.5439 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.923877 -0.382689 0 -0.216777" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8736 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.866018 0.500012 0 -0.0578658" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382688 -0.923878 0 66.8736 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="16.7825 -11.732 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.7825 0 1 0 -11.732 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.782503 -1.73207 0.25" />
                            <Vertex pos="-1.21751 -1.44138 0.25" />
                            <Vertex pos="1.21751 1.73207 0.25" />
                            <Vertex pos="-0.782503 -1.73207 -0.25" />
                            <Vertex pos="-1.21751 -1.44138 -0.25" />
                            <Vertex pos="1.21751 1.73207 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4296.32 0 -1 0 3003.39 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -612.159 0 -1 0 733.696 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.555607 -0.831445 -0 -1.87489" album="Blasted" material="bm_edge_white" texgens="0.831464 -0.555578 0 51.7852 0 0 -1 64 0 0.130796 0.125" texRot="0" texScale="0.130796 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.866026 -0.499998 0 -0.188364" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.79336 0.608753 0 -0.0884792" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.500005 -0.866023 0 67.48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="16.5858 -11.5867 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.5858 0 1 0 -11.5867 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.02083 -1.58671 0.25" />
                            <Vertex pos="-1.41421 -1.24174 0.25" />
                            <Vertex pos="1.41421 1.58671 0.25" />
                            <Vertex pos="-1.02083 -1.58671 -0.25" />
                            <Vertex pos="-1.41421 -1.24174 -0.25" />
                            <Vertex pos="1.41421 1.58671 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4245.96 0 -1 0 2966.2 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -586.981 0 -1 0 715.098 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.65933 -0.751854 -0 -1.86604" album="Blasted" material="bm_edge_white" texgens="0.751844 -0.659341 0 59.8223 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.793355 -0.60876 0 -0.156045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8312 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.707111 0.707103 0 -0.121965" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608758 -0.793356 0 67.8312 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="16.4133 -11.4142 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.4133 0 1 0 -11.4142 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.24171 -1.41422 0.25" />
                            <Vertex pos="-1.58672 -1.02084 0.25" />
                            <Vertex pos="1.58672 1.41422 0.25" />
                            <Vertex pos="-1.24171 -1.41422 -0.25" />
                            <Vertex pos="-1.58672 -1.02084 -0.25" />
                            <Vertex pos="1.58672 1.41422 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4201.8 0 -1 0 2922.04 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -564.901 0 -1 0 693.018 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751816 -0.659373 -0 -1.86604" album="Blasted" material="bm_edge_white" texgens="0.659351 -0.751835 0 68.1523 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.707108 -0.707106 0 -0.12198" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.9034 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.608761 0.793354 0 -0.156045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707103 -0.707111 0 67.9034 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="16.2679 -11.2175 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.2679 0 1 0 -11.2175 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.44135 -1.21754 0.25" />
                            <Vertex pos="-1.73203 -0.782472 0.25" />
                            <Vertex pos="1.73204 1.21754 0.25" />
                            <Vertex pos="-1.44135 -1.21754 -0.25" />
                            <Vertex pos="-1.73203 -0.782472 -0.25" />
                            <Vertex pos="1.73204 1.21754 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4164.58 0 -1 0 2871.68 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -546.29 0 -1 0 667.84 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.83149 -0.55554 -0 -1.87486" album="Blasted" material="bm_edge_white" texgens="0.555569 -0.83147 0 76.2476 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.60877 -0.793347 0 -0.0884816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6905 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.500006 0.866022 0 -0.188387" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.79335 -0.608765 0 67.6905 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="16.1523 -11 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.1523 0 1 0 -11 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.61637 -1 0.25" />
                            <Vertex pos="-1.84777 -0.530753 0.25" />
                            <Vertex pos="1.84777 1 0.25" />
                            <Vertex pos="-1.61637 -1 -0.25" />
                            <Vertex pos="-1.84777 -0.530753 -0.25" />
                            <Vertex pos="1.84777 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4134.99 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -531.493 0 -1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.896878 -0.442278 -0 -1.89196" album="Blasted" material="bm_edge_white" texgens="0.442299 -0.896868 0 83.4744 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.499996 -0.866028 0 -0.0578495" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.2059 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.382686 0.923879 0 -0.216764" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866024 -0.500003 0 67.2059 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="16.0681 -10.7654 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0681 0 1 0 -10.7654 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.76365 -0.765375 0.25" />
                            <Vertex pos="-1.93183 -0.269906 0.25" />
                            <Vertex pos="1.93183 0.765375 0.25" />
                            <Vertex pos="-1.76365 -0.765375 -0.25" />
                            <Vertex pos="-1.93183 -0.269906 -0.25" />
                            <Vertex pos="1.93183 0.765375 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4113.43 0 -1 0 2755.94 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -520.716 0 -1 0 609.971 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946935 -0.321424 -0 -1.91607" album="Blasted" material="bm_edge_white" texgens="0.321446 -0.946928 0 89.405 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.38269 -0.923877 0 -0.0321804" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.258823 0.965925 0 -0.239293" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.923878 -0.382688 0 66.486 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="16.0171 -10.5176 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0171 0 1 0 -10.5176 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.88082 -0.517643 0.25" />
                            <Vertex pos="-1.98291 -0.00448513 0.25" />
                            <Vertex pos="1.98291 0.517644 0.25" />
                            <Vertex pos="-1.88082 -0.517643 -0.25" />
                            <Vertex pos="-1.98291 -0.00448513 -0.25" />
                            <Vertex pos="1.98291 0.517644 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4100.38 0 -1 0 2692.51 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -514.188 0 -1 0 578.253 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980779 -0.195121 -0 -1.94567" album="Blasted" material="bm_edge_white" texgens="0.195097 -0.980784 0 93.5789 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.25882 -0.965926 0 -0.013211" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5782 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="-0.130531 0.991444 0 -0.254384" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965925 -0.258823 0 65.5782 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="16 -10.2611 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -10.2611 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.96579 -0.261064 0.25" />
                            <Vertex pos="-2.00001 0.261064 0.25" />
                            <Vertex pos="2.00001 0.261064 0.25" />
                            <Vertex pos="-1.96579 -0.261064 -0.25" />
                            <Vertex pos="-2.00001 0.261064 -0.25" />
                            <Vertex pos="2.00001 0.261064 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 2626.84 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 545.421 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.997859 -0.0653991 -0 -1.97866" album="Blasted" material="bm_edge_white" texgens="0.0654018 -0.997859 0 95.7393 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0.130531 -0.991444 0 -0.00223339" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5428 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 1 0 -0.261064" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 -0.130529 0 64.5428 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="16 -9.73895 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 -9.73895 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.99999 -0.261045 0.25" />
                            <Vertex pos="-1.96577 0.261046 0.25" />
                            <Vertex pos="1.99999 -0.261045 0.25" />
                            <Vertex pos="-1.99999 -0.261045 -0.25" />
                            <Vertex pos="-1.96577 0.261046 -0.25" />
                            <Vertex pos="1.99999 -0.261045 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 2493.17 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -511.999 0 -1 0 478.586 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.997859 0.0654038 0 -1.97863" album="Blasted" material="bm_edge_white" texgens="-0.0654019 -0.997859 0 32.2727 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.261045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9992 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130523 0.991445 0 -0.00223374" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -1 0 0 63.9992 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="16.0171 -9.48236 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0171 0 1 0 -9.48236 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.9829 0.00445366 0.25" />
                            <Vertex pos="-1.88081 0.517639 0.25" />
                            <Vertex pos="1.9829 -0.51764 0.25" />
                            <Vertex pos="-1.9829 0.00445366 -0.25" />
                            <Vertex pos="-1.88081 0.517639 -0.25" />
                            <Vertex pos="1.9829 -0.51764 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4100.38 0 -1 0 2427.48 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -514.188 0 -1 0 445.742 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.980781 0.195111 0 -1.94566" album="Blasted" material="bm_edge_white" texgens="-0.195078 -0.980788 0 34.4357 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130523 -0.991445 0 -0.254398" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 0.130524 0 65.0713 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258819 0.965926 0 -0.013211" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.991445 0.130524 0 65.0713 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="16.0681 -9.23464 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.0681 0 1 0 -9.23464 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.93186 0.269921 0.25" />
                            <Vertex pos="-1.76367 0.76536 0.25" />
                            <Vertex pos="1.93186 -0.765361 0.25" />
                            <Vertex pos="-1.93186 0.269921 -0.25" />
                            <Vertex pos="-1.76367 0.76536 -0.25" />
                            <Vertex pos="1.93186 -0.765361 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4113.43 0 -1 0 2364.07 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -520.716 0 -1 0 414.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.946924 0.321459 0 -1.91609" album="Blasted" material="bm_edge_white" texgens="-0.321446 -0.946928 0 38.6098 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258819 -0.965926 0 -0.239279" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.052 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.38268 0.923881 0 -0.032181" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.965926 0.258817 0 66.052 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="16.1522 -9 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.1522 0 1 0 -9 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.84777 0.53072 0.25" />
                            <Vertex pos="-1.61633 1 0.25" />
                            <Vertex pos="1.84777 -1 0.25" />
                            <Vertex pos="-1.84777 0.53072 -0.25" />
                            <Vertex pos="-1.61633 1 -0.25" />
                            <Vertex pos="1.84777 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4134.96 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -531.48 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.89686 0.442314 0 -1.89194" album="Blasted" material="bm_edge_white" texgens="-0.442299 -0.896868 0 44.5141 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.382679 -0.923882 0 -0.21678" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8729 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.5 0.866025 0 -0.05786" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.92388 0.382683 0 66.8729 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="16.268 -8.78248 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.268 0 1 0 -8.78248 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.73204 0.782483 0.25" />
                            <Vertex pos="-1.44139 1.21751 0.25" />
                            <Vertex pos="1.73204 -1.21751 0.25" />
                            <Vertex pos="-1.73204 0.782483 -0.25" />
                            <Vertex pos="-1.44139 1.21751 -0.25" />
                            <Vertex pos="1.73204 -1.21751 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4164.61 0 -1 0 2248.31 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -546.303 0 -1 0 356.157 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.831492 0.555536 0 -1.87488" album="Blasted" material="bm_edge_white" texgens="-0.555556 -0.83148 0 51.7557 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.500001 -0.866025 0 -0.188372" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4801 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608755 0.793358 0 -0.0884674" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.866026 0.499998 0 67.4801 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="16.4133 -8.5858 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.4133 0 1 0 -8.5858 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.58671 1.02083 0.25" />
                            <Vertex pos="-1.24174 1.4142 0.25" />
                            <Vertex pos="1.58671 -1.4142 0.25" />
                            <Vertex pos="-1.58671 1.02083 -0.25" />
                            <Vertex pos="-1.24174 1.4142 -0.25" />
                            <Vertex pos="1.58671 -1.4142 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4201.8 0 -1 0 2197.96 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -564.901 0 -1 0 330.982 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.751846 0.659339 0 -1.86603" album="Blasted" material="bm_edge_white" texgens="-0.659351 -0.751835 0 59.8258 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608758 -0.793356 0 -0.156041" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.793355 0.60876 0 67.8306 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707101 0.707113 0 -0.121964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.793355 0.60876 0 67.8306 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="16.5858 -8.4133 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.5858 0 1 0 -8.4133 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.41422 1.2417 0.25" />
                            <Vertex pos="-1.02084 1.5867 0.25" />
                            <Vertex pos="1.41422 -1.5867 0.25" />
                            <Vertex pos="-1.41422 1.2417 -0.25" />
                            <Vertex pos="-1.02084 1.5867 -0.25" />
                            <Vertex pos="1.41422 -1.5867 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4245.96 0 -1 0 2153.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -586.981 0 -1 0 308.902 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.659362 0.751826 0 -1.86602" album="Blasted" material="bm_edge_white" texgens="-0.751835 -0.659351 0 68.1757 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707102 -0.707112 0 -0.121977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9023 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.79335 0.608765 0 -0.156044" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.707108 0.707106 0 67.9023 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="16.7825 -8.26796 32.25" rot="1 0 0 0" scale="" transform="1 0 0 16.7825 0 1 0 -8.26796 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.21754 1.44136 0.25" />
                            <Vertex pos="-0.782476 1.73205 0.25" />
                            <Vertex pos="1.21754 -1.73205 0.25" />
                            <Vertex pos="-1.21754 1.44136 -0.25" />
                            <Vertex pos="-0.782476 1.73205 -0.25" />
                            <Vertex pos="1.21754 -1.73205 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4296.32 0 -1 0 2116.6 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -612.159 0 -1 0 290.299 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.555556 0.831479 0 -1.87487" album="Blasted" material="bm_edge_white" texgens="-0.831471 -0.555569 0 76.2312 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.793349 -0.608767 0 -0.0884812" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6898 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866024 0.500003 0 -0.188388" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.608763 0.793352 0 67.6898 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="17 -8.15223 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -8.15223 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.999998 1.61632 0.25" />
                            <Vertex pos="-0.530714 1.84776 0.25" />
                            <Vertex pos="0.999998 -1.84776 0.25" />
                            <Vertex pos="-0.999998 1.61632 -0.25" />
                            <Vertex pos="-0.530714 1.84776 -0.25" />
                            <Vertex pos="0.999998 -1.84776 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 2086.97 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -639.999 0 -1 0 275.485 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.442311 0.896862 0 -1.89193" album="Blasted" material="bm_edge_white" texgens="-0.896872 -0.442291 0 83.4719 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866024 -0.500002 0 -0.0578601" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.207 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923882 0.382679 0 -0.216781" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.5 0.866025 0 67.207 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="17.2346 -8.06816 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.2346 0 1 0 -8.06816 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.765362 1.76369 0.25" />
                            <Vertex pos="-0.269924 1.93185 0.25" />
                            <Vertex pos="0.76536 -1.93185 0.25" />
                            <Vertex pos="-0.765362 1.76369 -0.25" />
                            <Vertex pos="-0.269924 1.93185 -0.25" />
                            <Vertex pos="0.76536 -1.93185 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4412.06 0 -1 0 2065.45 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -670.028 0 -1 0 264.724 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.321408 0.946941 0 -1.9161" album="Blasted" material="bm_edge_white" texgens="-0.946934 -0.321429 0 89.3987 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.923881 -0.382679 0 -0.0321766" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382683 0.92388 0 66.4861 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 0.258821 0 -0.239277" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.382683 0.92388 0 66.4861 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="17.4824 -8.01713 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.4824 0 1 0 -8.01713 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.517641 1.88081 0.25" />
                            <Vertex pos="-0.00445175 1.98291 0.25" />
                            <Vertex pos="0.517639 -1.98291 0.25" />
                            <Vertex pos="-0.517641 1.88081 -0.25" />
                            <Vertex pos="-0.00445175 1.98291 -0.25" />
                            <Vertex pos="0.517639 -1.98291 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4475.49 0 -1 0 2052.39 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -701.746 0 -1 0 258.193 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.195128 0.980778 0 -1.94566" album="Blasted" material="bm_edge_white" texgens="-0.980784 -0.195099 0 93.5488 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965926 -0.258819 0 -0.0132136" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.5763 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991446 0.130521 0 -0.254399" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 -0.258818 0.965926 0 65.5763 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="17.739 -8 32.25" rot="1 0 0 0" scale="" transform="1 0 0 17.739 0 1 0 -8 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.26103 1.96578 0.25" />
                            <Vertex pos="0.261032 2 0.25" />
                            <Vertex pos="0.261032 -2 0.25" />
                            <Vertex pos="-0.26103 1.96578 -0.249996" />
                            <Vertex pos="0.261032 2 -0.249996" />
                            <Vertex pos="0.261032 -2 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="-0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4541.18 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 -1 -0.249996" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -734.591 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="-0.0654074 0.997859 0 -1.97864" album="Blasted" material="bm_edge_white" texgens="-0.997859 -0.0654019 0 95.7432 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991446 -0.130516 0 -0.00223216" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 -0.130525 0.991445 0 64.5428 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="1 -0 0 -0.261032" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8.00024 -0.130525 0.991445 0 64.5428 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="18.2611 -8 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.2611 0 1 0 -8 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.261063 2 0.25" />
                            <Vertex pos="0.261061 1.96578 0.25" />
                            <Vertex pos="-0.261063 -2 0.25" />
                            <Vertex pos="-0.261063 2 -0.25" />
                            <Vertex pos="0.261061 1.96578 -0.25" />
                            <Vertex pos="-0.261063 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4674.84 0 -1 0 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -801.42 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.0653996 0.997859 0 -1.97865" album="Blasted" material="bm_edge_white" texgens="-0.997859 0.065402 0 32.2544 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-1 0 0 -0.261063" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9991 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.991444 -0.130531 0 -0.0022324" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0 1 0 63.9991 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="18.5176 -8.01711 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.5176 0 1 0 -8.01711 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.00445175 1.98289 0.25" />
                            <Vertex pos="0.517639 1.88079 0.25" />
                            <Vertex pos="-0.517641 -1.98289 0.25" />
                            <Vertex pos="0.00445175 1.98289 -0.25" />
                            <Vertex pos="0.517639 1.88079 -0.25" />
                            <Vertex pos="-0.517641 -1.98289 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4740.51 0 -1 0 2052.38 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -834.251 0 -1 0 258.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.195128 0.980778 0 -1.94564" album="Blasted" material="bm_edge_white" texgens="-0.980784 0.195098 0 34.4536 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.991445 0.130523 0 -0.2544" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0719 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.965925 -0.258821 0 -0.0132118" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.130527 0.991445 0 65.0719 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="18.7654 -8.06814 32.25" rot="1 0 0 0" scale="" transform="1 0 0 18.7654 0 1 0 -8.06814 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.269907 1.93183 0.25" />
                            <Vertex pos="0.765375 1.76364 0.25" />
                            <Vertex pos="-0.765375 -1.93183 0.25" />
                            <Vertex pos="0.269907 1.93183 -0.25" />
                            <Vertex pos="0.765375 1.76364 -0.25" />
                            <Vertex pos="-0.765375 -1.93183 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4803.94 0 -1 0 2065.44 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -865.97 0 -1 0 264.722 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.321442 0.946929 0 -1.91607" album="Blasted" material="bm_edge_white" texgens="-0.946928 0.321446 0 38.6011 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.965925 0.258823 0 -0.239292" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0523 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.923876 -0.382691 0 -0.0321823" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.25882 0.965926 0 66.0523 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="19 -8.15226 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 -8.15226 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.53075 1.84776 0.25" />
                            <Vertex pos="0.999998 1.61635 0.25" />
                            <Vertex pos="-0.999998 -1.84776 0.25" />
                            <Vertex pos="0.53075 1.84776 -0.25" />
                            <Vertex pos="0.999998 1.61635 -0.25" />
                            <Vertex pos="-0.999998 -1.84776 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 2086.98 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -895.999 0 -1 0 275.489 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.442292 0.896871 0 -1.89195" album="Blasted" material="bm_edge_white" texgens="-0.896879 0.442276 0 44.5063 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.923878 0.382686 0 -0.216764" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.866026 -0.499998 0 -0.0578523" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.382686 0.923879 0 66.8731 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="19.2175 -8.26795 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.2175 0 1 0 -8.26795 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.782465 1.73204 0.25" />
                            <Vertex pos="1.21753 1.44135 0.25" />
                            <Vertex pos="-1.21753 -1.73204 0.25" />
                            <Vertex pos="0.782465 1.73204 -0.25" />
                            <Vertex pos="1.21753 1.44135 -0.25" />
                            <Vertex pos="-1.21753 -1.73204 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4919.68 0 -1 0 2116.6 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -923.839 0 -1 0 290.298 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.555556 0.831479 0 -1.87486" album="Blasted" material="bm_edge_white" texgens="-0.831465 0.555578 0 51.7485 0 0 -1 64 0 0.130805 0.125" texRot="0" texScale="0.130805 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.866025 0.500001 0 -0.188389" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4807 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.793349 -0.608767 0 -0.0884813" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.500002 0.866024 0 67.4807 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="19.4142 -8.41328 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.4142 0 1 0 -8.41328 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.02084 1.58669 0.25" />
                            <Vertex pos="1.41421 1.24169 0.25" />
                            <Vertex pos="-1.41421 -1.58669 0.25" />
                            <Vertex pos="1.02084 1.58669 -0.25" />
                            <Vertex pos="1.41421 1.24169 -0.25" />
                            <Vertex pos="-1.41421 -1.58669 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4970.04 0 -1 0 2153.8 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -949.016 0 -1 0 308.9 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.659371 0.751817 0 -1.86601" album="Blasted" material="bm_edge_white" texgens="-0.751835 0.659351 0 59.8174 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.79335 0.608766 0 -0.15604" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8324 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.707102 -0.707112 0 -0.121977" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.608763 0.793352 0 67.8324 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="19.5866 -8.58588 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.5866 0 1 0 -8.58588 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.24182 1.41428 0.25" />
                            <Vertex pos="1.58679 1.0209 0.25" />
                            <Vertex pos="-1.58679 -1.41428 0.25" />
                            <Vertex pos="1.24182 1.41428 -0.25" />
                            <Vertex pos="1.58677 1.02092 -0.25" />
                            <Vertex pos="-1.58668 -1.41417 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5014.17 0 -1 0 2197.99 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -971.083 0 -1 0 330.993 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.751854 0.65933 -3.52675e-006 -1.86614" album="Blasted" material="bm_edge_white" texgens="-0.659351 0.751835 0 68.1499 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.707101 0.707113 0 -0.121964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.8994 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.608762 -0.793353 -4.07661e-005 -0.156034" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.707108 0.707106 0 67.8994 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="19.7321 -8.78247 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.7321 0 1 0 -8.78247 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.44133 1.2175 0.25" />
                            <Vertex pos="1.73205 0.782467 0.25" />
                            <Vertex pos="-1.73205 -1.2175 0.25" />
                            <Vertex pos="1.44133 1.2175 -0.25" />
                            <Vertex pos="1.73205 0.782467 -0.25" />
                            <Vertex pos="-1.73205 -1.2175 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5051.42 0 -1 0 2248.31 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -989.708 0 -1 0 356.156 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.831434 0.555623 0 -1.87484" album="Blasted" material="bm_edge_white" texgens="-0.555569 0.831471 0 76.2725 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.608758 0.793356 0 -0.0884891" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.6919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.499994 -0.866029 0 -0.188376" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.793355 0.60876 0 67.6919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="19.8478 -9 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.8478 0 1 0 -9 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.61636 1 0.25" />
                            <Vertex pos="1.84777 0.53072 0.25" />
                            <Vertex pos="-1.84777 -1 0.25" />
                            <Vertex pos="1.61636 1 -0.25" />
                            <Vertex pos="1.84777 0.53072 -0.25" />
                            <Vertex pos="-1.84777 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5081.04 0 -1 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1004.52 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.896883 0.442268 0 -1.89195" album="Blasted" material="bm_edge_white" texgens="-0.442276 0.896879 0 83.4795 0 0 -1 64 0 0.130807 0.125" texRot="0" texScale="0.130807 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.499997 0.866027 0 -0.0578521" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2072 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.382679 -0.923882 0 -0.21678" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.866027 0.499997 0 67.2072 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="19.9319 -9.23464 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9319 0 1 0 -9.23464 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.76367 0.765358 0.25" />
                            <Vertex pos="1.93186 0.26989 0.25" />
                            <Vertex pos="-1.93186 -0.765357 0.25" />
                            <Vertex pos="1.76367 0.765358 -0.25" />
                            <Vertex pos="1.93186 0.26989 -0.25" />
                            <Vertex pos="-1.93186 -0.765357 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5102.57 0 -1 0 2364.07 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1015.28 0 -1 0 414.034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.946929 0.321442 0 -1.91609" album="Blasted" material="bm_edge_white" texgens="-0.321446 0.946928 0 89.3918 0 0 -1 64 0 0.130808 0.125" texRot="0" texScale="0.130808 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.382678 0.923882 0 -0.0321818" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4862 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.258811 -0.965928 0 -0.239293" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.923881 0.38268 0 66.4862 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="19.9829 -9.48238 32.25" rot="1 0 0 0" scale="" transform="1 0 0 19.9829 0 1 0 -9.48238 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.88083 0.517625 0.25" />
                            <Vertex pos="1.98289 0.00446796 0.25" />
                            <Vertex pos="-1.9829 -0.517626 0.25" />
                            <Vertex pos="1.88083 0.517625 -0.25" />
                            <Vertex pos="1.98289 0.00446796 -0.25" />
                            <Vertex pos="-1.9829 -0.517626 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5115.62 0 -1 0 2427.49 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1021.81 0 -1 0 445.745 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.98079 0.195066 0 -1.94567" album="Blasted" material="bm_edge_white" texgens="-0.195079 0.980788 0 93.5618 0 0 -1 64 0 0.130806 0.125" texRot="0" texScale="0.130806 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.258812 0.965928 0 -0.0132079" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.5777 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0.130523 -0.991445 0 -0.254383" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.965927 0.258815 0 65.5777 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="20 -9.73895 32.25" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 -9.73895 0 0 1 32.25 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1.96577 0.261045 0.25" />
                            <Vertex pos="1.99999 -0.261045 0.25" />
                            <Vertex pos="-1.99999 -0.261045 0.25" />
                            <Vertex pos="1.96577 0.261045 -0.25" />
                            <Vertex pos="1.99999 -0.261045 -0.25" />
                            <Vertex pos="-1.99999 -0.261045 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0 0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5120 0 -1 0 2493.17 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1024 0 -1 0 478.586 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="2" plane="0.997859 0.0654039 0 -1.97863" album="Blasted" material="bm_edge_white" texgens="-0.0654041 0.997859 0 95.73 0 0 -1 64 0 0.130802 0.125" texRot="0" texScale="0.130802 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="3" plane="-0.130523 0.991445 0 -0.00223327" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 0.130522 0 64.5422 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="4" plane="0 -1 0 -0.261045" album="Blasted" material="bm_edge_white" texgens="0 0 -1 8 0.991445 0.130522 0 64.5422 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="22.5 -18.2588 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 -18.2588 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 0.258819 0.5" />
                            <Vertex pos="0.93185 -0.258819 0.5" />
                            <Vertex pos="-1 0.258819 0.5" />
                            <Vertex pos="1 0.258818 0" />
                            <Vertex pos="0.93185 -0.258818 0" />
                            <Vertex pos="-1 0.258818 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2880 0 -1 0 2337.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1569.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.991444 -0.130529 -2.64525e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.13053 0.991444 0 33.0896 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0 1 -2.02656e-006 -0.258818" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.258819 -0.965926 1.9575e-006 -0.00882024" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="22.4659 -18.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.4659 0 1 0 -18.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.965925 -0.017637 0.5" />
                            <Vertex pos="0.766125 -0.5 0.5" />
                            <Vertex pos="-0.965925 0.5 0.5" />
                            <Vertex pos="0.965925 -0.0176373 0" />
                            <Vertex pos="0.766125 -0.5 0" />
                            <Vertex pos="-0.965925 0.5 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2875.64 0 -1 0 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -123.635 0 -1 0 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.92388 -0.382681 0 -0.899149" album="Blasted" material="bm_edge_white" texgens="0.382681 0.92388 0 41.373 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.258819 0.965926 -5.79335e-007 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258819 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.5 -0.866025 -0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258819 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="22.366 -18.7071 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.366 0 1 0 -18.7071 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.866025 -0.292895 0.5" />
                            <Vertex pos="0.548185 -0.707105 0.5" />
                            <Vertex pos="-0.866025 0.707105 0.5" />
                            <Vertex pos="0.866024 -0.292894 0" />
                            <Vertex pos="0.548185 -0.707106 0" />
                            <Vertex pos="-0.866024 0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2862.85 0 -1 0 2394.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -110.848 0 -1 0 1626.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.793348 -0.608768 1.2337e-006 -0.865365" album="Blasted" material="bm_edge_white" texgens="0.608768 0.793348 0 55.7163 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.500001 0.866025 7.49755e-007 -0.179359" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.707107 -0.707107 -2.78169e-006 -0.112372" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="22.2071 -18.866 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.2071 0 1 0 -18.866 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.707105 -0.548185 0.5" />
                            <Vertex pos="0.292891 -0.866025 0.5" />
                            <Vertex pos="-0.707105 0.866025 0.5" />
                            <Vertex pos="0.707106 -0.548185 0" />
                            <Vertex pos="0.292891 -0.866026 0" />
                            <Vertex pos="-0.707106 0.866026 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2842.51 0 -1 0 2414.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -90.5088 0 -1 0 1646.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.608764 -0.793351 1.60777e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="0.793351 0.608764 0 72.2831 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.707107 0.707107 1.43299e-006 -0.112374" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.866026 -0.499999 7.41776e-007 -0.17936" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="22 -18.9659 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -18.9659 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.499998 -0.766125 0.5" />
                            <Vertex pos="0.017634 -0.965925 0.5" />
                            <Vertex pos="-0.499998 0.965925 0.5" />
                            <Vertex pos="0.499998 -0.766125 0" />
                            <Vertex pos="0.0176334 -0.965925 0" />
                            <Vertex pos="-0.499998 0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2816 0 -1 0 2427.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -64 0 -1 0 1659.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.382681 -0.923881 -4.59042e-007 -0.899147" album="Blasted" material="bm_edge_white" texgens="0.923881 0.382681 0 86.6274 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.866026 0.499999 -0 -0.0499499" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499999 -0.866026 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.965927 -0.258816 -0 -0.232964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499999 -0.866026 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="21.7588 -19 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21.7588 0 1 0 -19 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25882 -0.93185 0.5" />
                            <Vertex pos="-0.25882 -1 0.5" />
                            <Vertex pos="-0.258812 1 0.5" />
                            <Vertex pos="0.25882 -0.93185 0" />
                            <Vertex pos="-0.25882 -1 0" />
                            <Vertex pos="-0.258812 1 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2785.13 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -33.1265 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.130529 -0.991444 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.991444 0.130529 0 94.9102 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.965927 0.258816 -0 -0.00882302" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258816 -0.965927 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-1 3.99351e-006 0 -0.258816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258816 -0.965927 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="21.2412 -19 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21.2412 0 1 0 -19 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.258816 -1 0.5" />
                            <Vertex pos="-0.258823 -0.93185 0.5" />
                            <Vertex pos="0.258823 1 0.5" />
                            <Vertex pos="0.258816 -1 0" />
                            <Vertex pos="-0.258823 -0.93185 0" />
                            <Vertex pos="0.258823 1 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2718.87 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 33.1265 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.130529 -0.991444 -0 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.991444 -0.130529 0 33.0907 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="1 -3.50177e-006 0 -0.25882" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.965925 0.258823 0 -0.0088194" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="21 -18.9659 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -18.9659 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.017641 -0.965925 0.5" />
                            <Vertex pos="-0.500005 -0.766125 0.5" />
                            <Vertex pos="0.500005 0.965925 0.5" />
                            <Vertex pos="-0.0176411 -0.965925 0" />
                            <Vertex pos="-0.500006 -0.766125 0" />
                            <Vertex pos="0.500006 0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2688 0 -1 0 2427.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 64 0 -1 0 1659.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.382681 -0.923881 7.75524e-007 -0.899151" album="Blasted" material="bm_edge_white" texgens="0.923881 -0.382681 0 41.3744 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.965925 -0.258823 -1.90713e-007 -0.232964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 33.9976 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.866023 0.500004 -1.75505e-006 -0.0499496" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 33.9976 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="20.7929 -18.866 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.7929 0 1 0 -18.866 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.292905 -0.866025 0.5" />
                            <Vertex pos="-0.707105 -0.548195 0.5" />
                            <Vertex pos="0.707105 0.866025 0.5" />
                            <Vertex pos="-0.292906 -0.866024 0" />
                            <Vertex pos="-0.707106 -0.548195 0" />
                            <Vertex pos="0.707106 0.866024 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2661.49 0 -1 0 2414.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 90.5088 0 -1 0 1646.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.608765 -0.79335 1.2337e-006 -0.865372" album="Blasted" material="bm_edge_white" texgens="0.79335 -0.608765 0 55.7171 0 0 -1 128 0 0.130523 0.125" texRot="0" texScale="0.130523 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.866022 -0.500005 -2.65711e-006 -0.179353" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500004 -0.866023 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.707109 0.707104 -2.78169e-006 -0.112368" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500004 -0.866023 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="20.634 -18.7071 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.634 0 1 0 -18.7071 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.548185 -0.70711 0.5" />
                            <Vertex pos="-0.866025 -0.2929 0.5" />
                            <Vertex pos="0.866025 0.70711 0.5" />
                            <Vertex pos="-0.548185 -0.707109 0" />
                            <Vertex pos="-0.866024 -0.2929 0" />
                            <Vertex pos="0.866024 0.707109 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2641.15 0 -1 0 2394.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 110.848 0 -1 0 1626.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.793348 -0.608768 -1.51319e-006 -0.865367" album="Blasted" material="bm_edge_white" texgens="0.608768 -0.793348 0 72.2828 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.707109 -0.707105 -1.43299e-006 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707104 -0.707109 0 35.596 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.500004 0.866023 -8.01364e-007 -0.179357" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707104 -0.707109 0 35.596 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="20.5341 -18.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.5341 0 1 0 -18.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.766125 -0.500005 0.5" />
                            <Vertex pos="-0.965925 -0.017639 0.5" />
                            <Vertex pos="0.965925 0.500005 0.5" />
                            <Vertex pos="-0.766125 -0.500006 0" />
                            <Vertex pos="-0.965925 -0.0176392 0" />
                            <Vertex pos="0.965925 0.500006 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2628.36 0 -1 0 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 123.635 0 -1 0 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.923881 -0.382679 1.52538e-007 -0.89915" album="Blasted" material="bm_edge_white" texgens="0.382679 -0.923881 0 86.6254 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.500005 -0.866023 1.75505e-006 -0.0499505" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866023 -0.500004 0 34.7686 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.258822 0.965925 1.9575e-006 -0.232966" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866023 -0.500004 0 34.7686 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="20.5 -18.2588 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -18.2588 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.93185 -0.258822 0.5" />
                            <Vertex pos="-1 0.258817 0.5" />
                            <Vertex pos="1 0.258822 0.5" />
                            <Vertex pos="-0.93185 -0.258821 0" />
                            <Vertex pos="-1 0.258818 0" />
                            <Vertex pos="1 0.258821 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2624 0 -1 0 2337.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1569.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.991445 -0.130529 -2.64525e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.130529 -0.991445 0 94.9097 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.258821 -0.965925 -1.89993e-006 -0.00881931" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-2.5034e-006 1 -1.96695e-006 -0.258819" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="20.5 -17.7412 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.5 0 1 0 -17.7412 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 -0.25882 0.5" />
                            <Vertex pos="-0.93185 0.25882 0.5" />
                            <Vertex pos="1 -0.258814 0.5" />
                            <Vertex pos="-1 -0.25882 0" />
                            <Vertex pos="-0.93185 0.25882 0" />
                            <Vertex pos="1 -0.258814 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2624 0 -1 0 2270.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1502.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.991444 0.130529 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.130529 -0.991444 0 33.0898 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="2.99513e-006 -1 0 -0.258817" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.258817 0.965926 0 -0.0088221" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="20.5341 -17.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.5341 0 1 0 -17.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.965925 0.0176354 0.5" />
                            <Vertex pos="-0.766125 0.499999 0.5" />
                            <Vertex pos="0.965925 -0.499999 0.5" />
                            <Vertex pos="-0.965925 0.0176353 0" />
                            <Vertex pos="-0.766125 0.499998 0" />
                            <Vertex pos="0.965925 -0.499998 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2628.36 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 123.635 0 -1 0 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.923881 0.382681 -7.52715e-007 -0.899148" album="Blasted" material="bm_edge_white" texgens="-0.382681 -0.923881 0 41.3727 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.258817 -0.965926 1.90713e-007 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965926 0.258817 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.499999 0.866026 1.70343e-006 -0.0499508" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965926 0.258817 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="20.634 -17.2929 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.634 0 1 0 -17.2929 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.866025 0.292892 0.5" />
                            <Vertex pos="-0.548185 0.707105 0.5" />
                            <Vertex pos="0.866025 -0.707105 0.5" />
                            <Vertex pos="-0.866026 0.292892 0" />
                            <Vertex pos="-0.548185 0.707106 0" />
                            <Vertex pos="0.866026 -0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2641.15 0 -1 0 2213.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 110.848 0 -1 0 1445.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.79335 0.608765 1.2337e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="-0.608765 -0.79335 0 55.7168 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.499999 -0.866026 1.01328e-006 -0.17936" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499999 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.707107 0.707107 0 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499999 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="20.7929 -17.134 32.5" rot="1 0 0 0" scale="" transform="1 0 0 20.7929 0 1 0 -17.134 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.707105 0.548185 0.5" />
                            <Vertex pos="-0.292895 0.866025 0.5" />
                            <Vertex pos="0.707105 -0.866025 0.5" />
                            <Vertex pos="-0.707106 0.548185 0" />
                            <Vertex pos="-0.292894 0.866024 0" />
                            <Vertex pos="0.707106 -0.866024 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2661.49 0 -1 0 2193.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 90.5088 0 -1 0 1425.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.608768 0.793348 -2.71061e-006 -0.865363" album="Blasted" material="bm_edge_white" texgens="-0.793348 -0.608768 0 72.2837 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.707106 -0.707107 1.43299e-006 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.866025 0.5 2.70873e-006 -0.179359" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="21 -17.0341 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 -17.0341 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.5 0.766125 0.5" />
                            <Vertex pos="-0.017637 0.965925 0.5" />
                            <Vertex pos="0.5 -0.965925 0.5" />
                            <Vertex pos="-0.5 0.766125 0" />
                            <Vertex pos="-0.0176373 0.965925 0" />
                            <Vertex pos="0.5 -0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2688 0 -1 0 2180.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 64 0 -1 0 1412.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.382681 0.92388 2.29521e-007 -0.899149" album="Blasted" material="bm_edge_white" texgens="-0.92388 -0.382681 0 86.627 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.866025 -0.5 0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.965926 0.258819 0 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="21.2412 -17 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21.2412 0 1 0 -17 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.258819 0.93185 0.5" />
                            <Vertex pos="0.258819 1 0.5" />
                            <Vertex pos="0.258818 -1 0.5" />
                            <Vertex pos="-0.25882 0.93185 0" />
                            <Vertex pos="0.25882 1 0" />
                            <Vertex pos="0.258818 -1 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2718.87 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 33.1265 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.130529 0.991444 -2.56745e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.991444 -0.130529 0 94.9102 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.965926 -0.258819 1.89993e-006 -0.00882025" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258819 0.965926 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="1 -5.06639e-007 0 -0.258819" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258819 0.965926 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="21.7588 -17 32.5" rot="1 0 0 0" scale="" transform="1 0 0 21.7588 0 1 0 -17 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.258819 1 0.5" />
                            <Vertex pos="0.258821 0.93185 0.5" />
                            <Vertex pos="-0.258821 -1 0.5" />
                            <Vertex pos="-0.25882 1 0" />
                            <Vertex pos="0.258821 0.93185 0" />
                            <Vertex pos="-0.258821 -1 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2785.13 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -33.1265 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.130529 0.991444 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.991445 0.130529 0 33.0902 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-1 5.06639e-007 1.96695e-006 -0.258821" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.965925 -0.258821 0 -0.00881934" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="22 -17.0341 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 -17.0341 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.017642 0.965925 0.5" />
                            <Vertex pos="0.5 0.766125 0.5" />
                            <Vertex pos="-0.5 -0.965925 0.5" />
                            <Vertex pos="0.017643 0.965925 0" />
                            <Vertex pos="0.5 0.766125 0" />
                            <Vertex pos="-0.5 -0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2816 0 -1 0 2180.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -64 0 -1 0 1412.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.382685 0.923879 0 -0.899149" album="Blasted" material="bm_edge_white" texgens="-0.923879 0.382685 0 41.3727 0 0 -1 128 0 0.130525 0.125" texRot="0" texScale="0.130525 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.965925 0.258822 -1.93231e-006 -0.23296" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258821 0.965925 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.866025 -0.5 0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258821 0.965925 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="22.2071 -17.134 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.2071 0 1 0 -17.134 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.29289 0.866025 0.5" />
                            <Vertex pos="0.70711 0.548185 0.5" />
                            <Vertex pos="-0.70711 -0.866025 0.5" />
                            <Vertex pos="0.292891 0.866026 0" />
                            <Vertex pos="0.707109 0.548185 0" />
                            <Vertex pos="-0.707109 -0.866026 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2842.51 0 -1 0 2193.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -90.5088 0 -1 0 1425.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.608759 0.793355 -1.23368e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="-0.793355 0.608759 0 55.7188 0 0 -1 128 0 0.130528 0.125" texRot="0" texScale="0.130528 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.866026 0.5 -6.90153e-007 -0.179362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.5 0.866025 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.707104 -0.707109 2.86599e-006 -0.112375" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.5 0.866025 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="22.366 -17.2929 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.366 0 1 0 -17.2929 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.548195 0.707105 0.5" />
                            <Vertex pos="0.866025 0.292889 0.5" />
                            <Vertex pos="-0.866025 -0.707105 0.5" />
                            <Vertex pos="0.548195 0.707106 0" />
                            <Vertex pos="0.866024 0.292889 0" />
                            <Vertex pos="-0.866024 -0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2862.85 0 -1 0 2213.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -110.848 0 -1 0 1445.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.793362 0.60875 -1.51322e-006 -0.865367" album="Blasted" material="bm_edge_white" texgens="-0.60875 0.793362 0 72.2803 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.707105 0.707109 1.433e-006 -0.112369" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707109 0.707104 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.499998 -0.866027 2.70872e-006 -0.179362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707109 0.707104 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="22.4659 -17.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.4659 0 1 0 -17.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.766125 0.499997 0.5" />
                            <Vertex pos="0.965925 0.017633 0.5" />
                            <Vertex pos="-0.965925 -0.499997 0.5" />
                            <Vertex pos="0.766125 0.499996 0" />
                            <Vertex pos="0.965925 0.0176334 0" />
                            <Vertex pos="-0.965925 -0.499996 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2875.64 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -123.635 0 -1 0 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.923881 0.382681 3.06503e-007 -0.899147" album="Blasted" material="bm_edge_white" texgens="-0.382681 0.923881 0 86.6276 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.499997 0.866027 -1.70343e-006 -0.0499497" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499998 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.258815 -0.965927 -1.89993e-006 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499998 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="22.5 -17.7412 32.5" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 -17.7412 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.93185 0.258815 0.5" />
                            <Vertex pos="1 -0.258815 0.5" />
                            <Vertex pos="-1 -0.258815 0.5" />
                            <Vertex pos="0.93185 0.258816 0" />
                            <Vertex pos="1 -0.258816 0" />
                            <Vertex pos="-1 -0.258816 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 2880 0 -1 0 2270.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1502.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.991444 0.130531 -2.64529e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.130531 0.991444 0 94.9112 0 0 -1 128 0 0.130525 0.125" texRot="0" texScale="0.130525 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.258816 0.965927 1.95751e-006 -0.00881918" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0 -1 2.02656e-006 -0.258816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="15.5 -18.2588 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.5 0 1 0 -18.2588 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="1 0.258819 0.5" />
                            <Vertex pos="0.93185 -0.258819 0.5" />
                            <Vertex pos="-1 0.258819 0.5" />
                            <Vertex pos="1 0.258818 0" />
                            <Vertex pos="0.93185 -0.258818 0" />
                            <Vertex pos="-1 0.258818 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1984 0 -1 0 2337.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1569.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.991444 -0.130529 -2.64525e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.13053 0.991444 0 33.0896 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0 1 -2.02656e-006 -0.258818" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.258819 -0.965926 1.9575e-006 -0.00882024" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="15.4659 -18.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.4659 0 1 0 -18.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.965925 -0.017637 0.5" />
                            <Vertex pos="0.766125 -0.5 0.5" />
                            <Vertex pos="-0.965925 0.5 0.5" />
                            <Vertex pos="0.965925 -0.0176373 0" />
                            <Vertex pos="0.766125 -0.5 0" />
                            <Vertex pos="-0.965925 0.5 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1979.64 0 -1 0 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -123.635 0 -1 0 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.92388 -0.382681 0 -0.899149" album="Blasted" material="bm_edge_white" texgens="0.382681 0.92388 0 41.373 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.258819 0.965926 -5.79335e-007 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258819 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.5 -0.866025 -0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965926 -0.258819 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="15.366 -18.7071 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.366 0 1 0 -18.7071 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.866025 -0.292895 0.5" />
                            <Vertex pos="0.548185 -0.707105 0.5" />
                            <Vertex pos="-0.866025 0.707105 0.5" />
                            <Vertex pos="0.866024 -0.292894 0" />
                            <Vertex pos="0.548185 -0.707106 0" />
                            <Vertex pos="-0.866024 0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1966.85 0 -1 0 2394.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -110.848 0 -1 0 1626.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.793348 -0.608768 1.2337e-006 -0.865365" album="Blasted" material="bm_edge_white" texgens="0.608768 0.793348 0 55.7163 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.500001 0.866025 7.49755e-007 -0.179359" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.707107 -0.707107 -2.78169e-006 -0.112372" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866025 -0.5 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="15.2071 -18.866 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.2071 0 1 0 -18.866 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.707105 -0.548185 0.5" />
                            <Vertex pos="0.292891 -0.866025 0.5" />
                            <Vertex pos="-0.707105 0.866025 0.5" />
                            <Vertex pos="0.707106 -0.548185 0" />
                            <Vertex pos="0.292891 -0.866026 0" />
                            <Vertex pos="-0.707106 0.866026 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1946.51 0 -1 0 2414.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -90.5088 0 -1 0 1646.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.608764 -0.793351 1.60777e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="0.793351 0.608764 0 72.2831 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.707107 0.707107 1.43299e-006 -0.112374" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.866026 -0.499999 7.41776e-007 -0.17936" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707107 -0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="15 -18.9659 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -18.9659 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.499998 -0.766125 0.5" />
                            <Vertex pos="0.017634 -0.965925 0.5" />
                            <Vertex pos="-0.499998 0.965925 0.5" />
                            <Vertex pos="0.499998 -0.766125 0" />
                            <Vertex pos="0.0176334 -0.965925 0" />
                            <Vertex pos="-0.499998 0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1920 0 -1 0 2427.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -64 0 -1 0 1659.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.382681 -0.923881 -4.59042e-007 -0.899147" album="Blasted" material="bm_edge_white" texgens="0.923881 0.382681 0 86.6274 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.866026 0.499999 -0 -0.0499499" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499999 -0.866026 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.965927 -0.258816 -0 -0.232964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.499999 -0.866026 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="14.7588 -19 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14.7588 0 1 0 -19 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25882 -0.93185 0.5" />
                            <Vertex pos="-0.25882 -1 0.5" />
                            <Vertex pos="-0.258812 1 0.5" />
                            <Vertex pos="0.25882 -0.93185 0" />
                            <Vertex pos="-0.25882 -1 0" />
                            <Vertex pos="-0.258812 1 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1889.13 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -33.1265 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.130529 -0.991444 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.991444 0.130529 0 94.9102 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.965927 0.258816 -0 -0.00882302" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258816 -0.965927 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-1 3.99351e-006 0 -0.258816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258816 -0.965927 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="14.2412 -19 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14.2412 0 1 0 -19 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.258816 -1 0.5" />
                            <Vertex pos="-0.258823 -0.93185 0.5" />
                            <Vertex pos="0.258823 1 0.5" />
                            <Vertex pos="0.258816 -1 0" />
                            <Vertex pos="-0.258823 -0.93185 0" />
                            <Vertex pos="0.258823 1 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1822.87 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 33.1265 0 -1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.130529 -0.991444 -0 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.991444 -0.130529 0 33.0907 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="1 -3.50177e-006 0 -0.25882" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.965925 0.258823 0 -0.0088194" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 -1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="14 -18.9659 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -18.9659 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.017641 -0.965925 0.5" />
                            <Vertex pos="-0.500005 -0.766125 0.5" />
                            <Vertex pos="0.500005 0.965925 0.5" />
                            <Vertex pos="-0.0176411 -0.965925 0" />
                            <Vertex pos="-0.500006 -0.766125 0" />
                            <Vertex pos="0.500006 0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1792 0 -1 0 2427.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 64 0 -1 0 1659.64 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.382681 -0.923881 7.75524e-007 -0.899151" album="Blasted" material="bm_edge_white" texgens="0.923881 -0.382681 0 41.3744 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.965925 -0.258823 -1.90713e-007 -0.232964" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 33.9976 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.866023 0.500004 -1.75505e-006 -0.0499496" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258823 -0.965925 0 33.9976 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="13.7929 -18.866 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.7929 0 1 0 -18.866 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.292905 -0.866025 0.5" />
                            <Vertex pos="-0.707105 -0.548195 0.5" />
                            <Vertex pos="0.707105 0.866025 0.5" />
                            <Vertex pos="-0.292906 -0.866024 0" />
                            <Vertex pos="-0.707106 -0.548195 0" />
                            <Vertex pos="0.707106 0.866024 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1765.49 0 -1 0 2414.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 90.5088 0 -1 0 1646.85 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.608765 -0.79335 1.2337e-006 -0.865372" album="Blasted" material="bm_edge_white" texgens="0.79335 -0.608765 0 55.7171 0 0 -1 128 0 0.130523 0.125" texRot="0" texScale="0.130523 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.866022 -0.500005 -2.65711e-006 -0.179353" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500004 -0.866023 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.707109 0.707104 -2.78169e-006 -0.112368" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.500004 -0.866023 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="13.634 -18.7071 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.634 0 1 0 -18.7071 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.548185 -0.70711 0.5" />
                            <Vertex pos="-0.866025 -0.2929 0.5" />
                            <Vertex pos="0.866025 0.70711 0.5" />
                            <Vertex pos="-0.548185 -0.707109 0" />
                            <Vertex pos="-0.866024 -0.2929 0" />
                            <Vertex pos="0.866024 0.707109 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1745.15 0 -1 0 2394.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 110.848 0 -1 0 1626.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.793348 -0.608768 -1.51319e-006 -0.865367" album="Blasted" material="bm_edge_white" texgens="0.608768 -0.793348 0 72.2828 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.707109 -0.707105 -1.43299e-006 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707104 -0.707109 0 35.596 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.500004 0.866023 -8.01364e-007 -0.179357" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707104 -0.707109 0 35.596 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="13.5341 -18.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.5341 0 1 0 -18.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.766125 -0.500005 0.5" />
                            <Vertex pos="-0.965925 -0.017639 0.5" />
                            <Vertex pos="0.965925 0.500005 0.5" />
                            <Vertex pos="-0.766125 -0.500006 0" />
                            <Vertex pos="-0.965925 -0.0176392 0" />
                            <Vertex pos="0.965925 0.500006 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1732.36 0 -1 0 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 123.635 0 -1 0 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.923881 -0.382679 1.52538e-007 -0.89915" album="Blasted" material="bm_edge_white" texgens="0.382679 -0.923881 0 86.6254 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.500005 -0.866023 1.75505e-006 -0.0499505" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866023 -0.500004 0 34.7686 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-0.258822 0.965925 1.9575e-006 -0.232966" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866023 -0.500004 0 34.7686 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="13.5 -18.2588 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 -18.2588 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.93185 -0.258822 0.5" />
                            <Vertex pos="-1 0.258817 0.5" />
                            <Vertex pos="1 0.258822 0.5" />
                            <Vertex pos="-0.93185 -0.258821 0" />
                            <Vertex pos="-1 0.258818 0" />
                            <Vertex pos="1 0.258821 0" />
                        </Vertices>
                        <Face id="5" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1728 0 -1 0 2337.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1569.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.991445 -0.130529 -2.64525e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="0.130529 -0.991445 0 94.9097 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="0.258821 -0.965925 -1.89993e-006 -0.00881931" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="-2.5034e-006 1 -1.96695e-006 -0.258819" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965925 -0.258822 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="13.5 -17.7412 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.5 0 1 0 -17.7412 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1 -0.25882 0.5" />
                            <Vertex pos="-0.93185 0.25882 0.5" />
                            <Vertex pos="1 -0.258814 0.5" />
                            <Vertex pos="-1 -0.25882 0" />
                            <Vertex pos="-0.93185 0.25882 0" />
                            <Vertex pos="1 -0.258814 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1728 0 -1 0 2270.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1502.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.991444 0.130529 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.130529 -0.991444 0 33.0898 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="2.99513e-006 -1 0 -0.258817" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.258817 0.965926 0 -0.0088221" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -1 0 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="13.5341 -17.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.5341 0 1 0 -17.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.965925 0.0176354 0.5" />
                            <Vertex pos="-0.766125 0.499999 0.5" />
                            <Vertex pos="0.965925 -0.499999 0.5" />
                            <Vertex pos="-0.965925 0.0176353 0" />
                            <Vertex pos="-0.766125 0.499998 0" />
                            <Vertex pos="0.965925 -0.499998 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1732.36 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 123.635 0 -1 0 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.923881 0.382681 -7.52715e-007 -0.899148" album="Blasted" material="bm_edge_white" texgens="-0.382681 -0.923881 0 41.3727 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.258817 -0.965926 1.90713e-007 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965926 0.258817 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.499999 0.866026 1.70343e-006 -0.0499508" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.965926 0.258817 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="13.634 -17.2929 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.634 0 1 0 -17.2929 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.866025 0.292892 0.5" />
                            <Vertex pos="-0.548185 0.707105 0.5" />
                            <Vertex pos="0.866025 -0.707105 0.5" />
                            <Vertex pos="-0.866026 0.292892 0" />
                            <Vertex pos="-0.548185 0.707106 0" />
                            <Vertex pos="0.866026 -0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1745.15 0 -1 0 2213.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 110.848 0 -1 0 1445.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.79335 0.608765 1.2337e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="-0.608765 -0.79335 0 55.7168 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.499999 -0.866026 1.01328e-006 -0.17936" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499999 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.707107 0.707107 0 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.866026 0.499999 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="13.7929 -17.134 32.5" rot="1 0 0 0" scale="" transform="1 0 0 13.7929 0 1 0 -17.134 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.707105 0.548185 0.5" />
                            <Vertex pos="-0.292895 0.866025 0.5" />
                            <Vertex pos="0.707105 -0.866025 0.5" />
                            <Vertex pos="-0.707106 0.548185 0" />
                            <Vertex pos="-0.292894 0.866024 0" />
                            <Vertex pos="0.707106 -0.866024 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1765.49 0 -1 0 2193.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 90.5088 0 -1 0 1425.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.608768 0.793348 -2.71061e-006 -0.865363" album="Blasted" material="bm_edge_white" texgens="-0.793348 -0.608768 0 72.2837 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.707106 -0.707107 1.43299e-006 -0.112373" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.866025 0.5 2.70873e-006 -0.179359" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.707107 0.707107 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="14 -17.0341 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -17.0341 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.5 0.766125 0.5" />
                            <Vertex pos="-0.017637 0.965925 0.5" />
                            <Vertex pos="0.5 -0.965925 0.5" />
                            <Vertex pos="-0.5 0.766125 0" />
                            <Vertex pos="-0.0176373 0.965925 0" />
                            <Vertex pos="0.5 -0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1792 0 -1 0 2180.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 -0 -1 0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 64 0 -1 0 1412.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.382681 0.92388 2.29521e-007 -0.899149" album="Blasted" material="bm_edge_white" texgens="-0.92388 -0.382681 0 86.627 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.866025 -0.5 0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.965926 0.258819 0 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.5 0.866025 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="14.2412 -17 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14.2412 0 1 0 -17 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.258819 0.93185 0.5" />
                            <Vertex pos="0.258819 1 0.5" />
                            <Vertex pos="0.258818 -1 0.5" />
                            <Vertex pos="-0.25882 0.93185 0" />
                            <Vertex pos="0.25882 1 0" />
                            <Vertex pos="0.258818 -1 0" />
                        </Vertices>
                        <Face id="5" plane="-0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1822.87 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 33.1265 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="-0.130529 0.991444 -2.56745e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.991444 -0.130529 0 94.9102 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.965926 -0.258819 1.89993e-006 -0.00882025" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258819 0.965926 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="1 -5.06639e-007 0 -0.258819" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 -0.258819 0.965926 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="14.7588 -17 32.5" rot="1 0 0 0" scale="" transform="1 0 0 14.7588 0 1 0 -17 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.258819 1 0.5" />
                            <Vertex pos="0.258821 0.93185 0.5" />
                            <Vertex pos="-0.258821 -1 0.5" />
                            <Vertex pos="-0.25882 1 0" />
                            <Vertex pos="0.258821 0.93185 0" />
                            <Vertex pos="-0.258821 -1 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1889.13 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -33.1265 0 -1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.130529 0.991444 0 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.991445 0.130529 0 33.0902 0 0 -1 128 0 0.130527 0.125" texRot="0" texScale="0.130527 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-1 5.06639e-007 1.96695e-006 -0.258821" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.965925 -0.258821 0 -0.00881934" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0 1 0 32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="15 -17.0341 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -17.0341 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.017642 0.965925 0.5" />
                            <Vertex pos="0.5 0.766125 0.5" />
                            <Vertex pos="-0.5 -0.965925 0.5" />
                            <Vertex pos="0.017643 0.965925 0" />
                            <Vertex pos="0.5 0.766125 0" />
                            <Vertex pos="-0.5 -0.965925 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1920 0 -1 0 2180.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -64 0 -1 0 1412.36 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.382685 0.923879 0 -0.899149" album="Blasted" material="bm_edge_white" texgens="-0.923879 0.382685 0 41.3727 0 0 -1 128 0 0.130525 0.125" texRot="0" texScale="0.130525 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.965925 0.258822 -1.93231e-006 -0.23296" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258821 0.965925 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.866025 -0.5 0 -0.04995" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.258821 0.965925 0 33.9975 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="15.2071 -17.134 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.2071 0 1 0 -17.134 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.29289 0.866025 0.5" />
                            <Vertex pos="0.70711 0.548185 0.5" />
                            <Vertex pos="-0.70711 -0.866025 0.5" />
                            <Vertex pos="0.292891 0.866026 0" />
                            <Vertex pos="0.707109 0.548185 0" />
                            <Vertex pos="-0.707109 -0.866026 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1946.51 0 -1 0 2193.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -90.5088 0 -1 0 1425.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.608759 0.793355 -1.23368e-006 -0.865364" album="Blasted" material="bm_edge_white" texgens="-0.793355 0.608759 0 55.7188 0 0 -1 128 0 0.130528 0.125" texRot="0" texScale="0.130528 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.866026 0.5 -6.90153e-007 -0.179362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.5 0.866025 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.707104 -0.707109 2.86599e-006 -0.112375" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.5 0.866025 0 35.3137 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="15.366 -17.2929 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.366 0 1 0 -17.2929 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.548195 0.707105 0.5" />
                            <Vertex pos="0.866025 0.292889 0.5" />
                            <Vertex pos="-0.866025 -0.707105 0.5" />
                            <Vertex pos="0.548195 0.707106 0" />
                            <Vertex pos="0.866024 0.292889 0" />
                            <Vertex pos="-0.866024 -0.707106 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1966.85 0 -1 0 2213.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -110.848 0 -1 0 1445.49 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.793362 0.60875 -1.51322e-006 -0.865367" album="Blasted" material="bm_edge_white" texgens="-0.60875 0.793362 0 72.2803 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.707105 0.707109 1.433e-006 -0.112369" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707109 0.707104 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.499998 -0.866027 2.70872e-006 -0.179362" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.707109 0.707104 0 35.5959 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="15.4659 -17.5 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.4659 0 1 0 -17.5 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.766125 0.499997 0.5" />
                            <Vertex pos="0.965925 0.017633 0.5" />
                            <Vertex pos="-0.965925 -0.499997 0.5" />
                            <Vertex pos="0.766125 0.499996 0" />
                            <Vertex pos="0.965925 0.0176334 0" />
                            <Vertex pos="-0.965925 -0.499996 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1979.64 0 -1 0 2240 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="-0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -123.635 0 -1 0 1472 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.923881 0.382681 3.06503e-007 -0.899147" album="Blasted" material="bm_edge_white" texgens="-0.382681 0.923881 0 86.6276 0 0 -1 128 0 0.130526 0.125" texRot="0" texScale="0.130526 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.499997 0.866027 -1.70343e-006 -0.0499497" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499998 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0.258815 -0.965927 -1.89993e-006 -0.232963" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.866027 0.499998 0 34.7685 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="15.5 -17.7412 32.5" rot="1 0 0 0" scale="" transform="1 0 0 15.5 0 1 0 -17.7412 0 0 1 32.5 0 0 0 1" group="-1" locked="0" nextFaceID="11" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.93185 0.258815 0.5" />
                            <Vertex pos="1 -0.258815 0.5" />
                            <Vertex pos="-1 -0.258815 0.5" />
                            <Vertex pos="0.93185 0.258816 0" />
                            <Vertex pos="1 -0.258816 0" />
                            <Vertex pos="-1 -0.258816 0" />
                        </Vertices>
                        <Face id="5" plane="0 0 1 -0.5" album="Blasted" material="bm_friction_snow" texgens="1 0 0 1984 0 -1 0 2270.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="6" plane="0 0 -1 -0" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -128 0 -1 0 1502.87 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                        <Face id="7" plane="0.991444 0.130531 -2.64529e-007 -0.957661" album="Blasted" material="bm_edge_white" texgens="-0.130531 0.991444 0 94.9112 0 0 -1 128 0 0.130525 0.125" texRot="0" texScale="0.130525 0.125" texDiv="128 128">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="8" plane="-0.258816 0.965927 1.95751e-006 -0.00881918" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="9" plane="0 -1 2.02656e-006 -0.258816" album="Blasted" material="bm_edge_white" texgens="0 0 -1 16 0.965927 0.258815 0 33.0532 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
