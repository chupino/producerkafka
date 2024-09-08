git clone https://github.com/chupino/producerkafka.git producer
cd producer

docker build -t producer .

if [ $? -eq 0 ]; then
    echo "todo bien"
else
    echo "mal"
    exit 1
fi

docker run -d producer