from yandex_tracker_client import TrackerClient
import requests

url = "https://iam.api.cloud.yandex.net/iam/v1/tokens"
headers = {
    "Content-Type": "application/json",
}

data = {
    "yandexPassportOauthToken": "y0_AgAAAABUCVT5AATuwQAAAAD0GhwS4VVn6vfLS5eZnKGW-I18Upywh_8"
}

response = requests.post(url, json=data, headers=headers)
iam_token = response.json()["iamToken"]

client = TrackerClient(iam_token=iam_token, cloud_org_id="bpf03jjagkgrpums4gtp")

# queue = client.queues['TCBUILDFAILS']
# print(queue)
client.issues.create(queue='TCBUILDFAILS', summary='One of builds steps failed', type={'name': 'Bug'}, description='please fix', assignee="danil.kuryata")

# print(queue)